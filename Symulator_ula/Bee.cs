using System;
using System.Drawing;

namespace Symulator_ula
{
	[Serializable]
	internal class Bee
	{
		private const double HoneyConsumed = 0.5;
		private const int MoveRate = 3;
		private const double MinimumFlowerNectar = 1.5;
		private const int CareerSpan = 1000;

		private readonly int ID;
		private Flower destinationFlower;
		private readonly Hive hive;
		private readonly World world;

		public int Age { get; private set; }
		public bool InsideHive { get; private set; }
		public double NectarCollected { get; private set; }
		public BeeState CurrentState { get; private set; }

		private Point location;
		public Point Location => location;

		[NonSerialized]
		public BeeMessage MessageSender;

		public Bee(int id, Point location, Hive hive, World world)
		{
			this.hive = hive;
			this.world = world;
			ID = id;
			Age = 0;
			this.location = location;
			InsideHive = true;
			destinationFlower = null;
			NectarCollected = 0;
			CurrentState = BeeState.Idle;
		}

		public void Go(Random random)
		{
			Age++;

			BeeState oldState = CurrentState;

			switch (CurrentState)
			{
				case BeeState.Idle:
					if (Age > CareerSpan)
					{
						CurrentState = BeeState.Retired;
					}
					else if (world.Flowers.Count > 0 && hive.ConsumeHoney(HoneyConsumed))
					{
						Flower flower = world.Flowers[random.Next(world.Flowers.Count)];
						if (flower.Nectar >= MinimumFlowerNectar && flower.Alive)
						{
							destinationFlower = flower;
							CurrentState = BeeState.FlyingToFlower;
						}
					}
					break;
				case BeeState.FlyingToFlower:
					if (!world.Flowers.Contains(destinationFlower))
					{
						CurrentState = BeeState.ReturningToHive;
					}
					else if (InsideHive)
					{
						if (MoveTowardsLocation(hive.GetLocation("Wyjście")))
						{
							InsideHive = false;
							location = hive.GetLocation("Wejście");
						}
					}
					else
						if (MoveTowardsLocation(destinationFlower.Location))
					{
						CurrentState = BeeState.GatheringNectar;
					}

					break;
				case BeeState.GatheringNectar:
					double nectar = destinationFlower.HarvestNectar();
					if (nectar > 0)
					{
						NectarCollected += nectar;
					}
					else
					{
						CurrentState = BeeState.ReturningToHive;
					}

					break;
				case BeeState.ReturningToHive:
					if (!InsideHive)
					{
						if (MoveTowardsLocation(hive.GetLocation("Wejście")))
						{
							InsideHive = true;
							location = hive.GetLocation("Wyjście");
						}
					}
					else
					{
						if (MoveTowardsLocation(hive.GetLocation("Fabryka miodu")))
						{
							CurrentState = BeeState.MakingHoney;
						}
					}
					break;
				case BeeState.MakingHoney:
					if (NectarCollected < 0.5)
					{
						NectarCollected = 0;
						CurrentState = BeeState.Idle;
					}
					else
					{
						if (hive.AddHoney(0.5))
						{
							NectarCollected -= 0.5;
						}
						else
						{
							NectarCollected = 0;
						}
					}
					break;
				case BeeState.Retired:
					break;
				default:
					break;
			}

			if (oldState != CurrentState && MessageSender != null)
			{
				string stringState;
				switch (CurrentState)
				{
					case BeeState.FlyingToFlower:
						stringState = "leci do kwiatów";
						break;
					case BeeState.GatheringNectar:
						stringState = "zbiera nektar";
						break;
					case BeeState.ReturningToHive:
						stringState = "wraca do ula";
						break;
					case BeeState.MakingHoney:
						stringState = "wytwarza miód";
						break;
					case BeeState.Retired:
						stringState = "na emeryturze";
						break;
					default:
						stringState = "bezrobotna";
						break;
				}
				MessageSender(ID, stringState);
			}
		}

		private bool MoveTowardsLocation(Point destination)
		{
			if (Math.Abs(destination.X - location.X) <= MoveRate && Math.Abs(destination.Y - location.Y) <= MoveRate)
			{
				return true;
			}

			if (destination.X > location.X)
			{
				location.X += MoveRate;
			}
			else if (destination.X < location.X)
			{
				location.X -= MoveRate;
			}

			if (destination.Y > location.Y)
			{
				location.Y += MoveRate;
			}
			else if (destination.Y < location.Y)
			{
				location.Y -= MoveRate;
			}

			return false;
		}
	}
}