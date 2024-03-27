using System;
using System.Drawing;

namespace Hive_simulator
{
	[Serializable]
	internal class Bee
	{
		private const double HoneyConsumed = 0.5;
		private const double MinimumFlowerNectar = 1.5;
		private const int MoveRate = 3;
		private const int CareerSpan = 1000;

		private readonly int _id;
		private readonly Hive _hive;
		private readonly World _world;

		private Flower _destinationFlower;
		private Point _location;

		[NonSerialized]
		public BeeMessage MessageSender;

		public Bee(int id, Point location, Hive hive, World world)
		{
			_id = id;
			_location = location;
			_hive = hive;
			_world = world;
			_destinationFlower = null;
			
			Age = 0;
			InsideHive = true;
			NectarCollected = 0;
			CurrentState = BeeState.Idle;
		}

		public Point Location
			=> _location;

		public int Age { get; private set; }
		public bool InsideHive { get; private set; }
		public double NectarCollected { get; private set; }
		public BeeState CurrentState { get; private set; }

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
					else if (_world.Flowers.Count > 0 && _hive.ConsumeHoney(HoneyConsumed))
					{
						Flower flower = _world.Flowers[random.Next(_world.Flowers.Count)];
						if (flower.Nectar >= MinimumFlowerNectar && flower.Alive)
						{
							_destinationFlower = flower;
							CurrentState = BeeState.FlyingToFlower;
						}
					}
					break;
				case BeeState.FlyingToFlower:
					if (!_world.Flowers.Contains(_destinationFlower))
					{
						CurrentState = BeeState.ReturningToHive;
					}
					else if (InsideHive)
					{
						if (MoveTowardsLocation(_hive.GetLocation("Wyjście")))
						{
							InsideHive = false;
							_location = _hive.GetLocation("Wejście");
						}
					}
					else
						if (MoveTowardsLocation(_destinationFlower.Location))
					{
						CurrentState = BeeState.GatheringNectar;
					}

					break;
				case BeeState.GatheringNectar:
					double nectar = _destinationFlower.HarvestNectar();
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
						if (MoveTowardsLocation(_hive.GetLocation("Wejście")))
						{
							InsideHive = true;
							_location = _hive.GetLocation("Wyjście");
						}
					}
					else
					{
						if (MoveTowardsLocation(_hive.GetLocation("Fabryka miodu")))
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
						if (_hive.AddHoney(0.5))
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
				MessageSender(_id, stringState);
			}
		}

		private bool MoveTowardsLocation(Point destination)
		{
			if (Math.Abs(destination.X - _location.X) <= MoveRate && Math.Abs(destination.Y - _location.Y) <= MoveRate)
			{
				return true;
			}

			if (destination.X > _location.X)
			{
				_location.X += MoveRate;
			}
			else if (destination.X < _location.X)
			{
				_location.X -= MoveRate;
			}

			if (destination.Y > _location.Y)
			{
				_location.Y += MoveRate;
			}
			else if (destination.Y < _location.Y)
			{
				_location.Y -= MoveRate;
			}

			return false;
		}
	}
}