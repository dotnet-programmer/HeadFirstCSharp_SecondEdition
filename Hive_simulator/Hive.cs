using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Hive_simulator
{
	[Serializable]
	internal class Hive
	{
		private const int InitialBees = 6;
		private const int MaxBees = 8;

		private const double InitialHoney = 3.2;
		private const double MaxHoney = 15.0;
		private const double NectarHoneyRatio = 0.25;
		private const double MinimumHoneyForCreatingBees = 4.0;

		private Dictionary<string, Point> _locations;
		private int _beeCount = 0;
		private readonly World _world;

		[NonSerialized]
		public BeeMessage MessageSender;

		public Hive(World world, BeeMessage MessageSender)
		{
			this.MessageSender = MessageSender;
			_world = world;
			Honey = InitialHoney;
			InitializeLocations();
			Random random = new Random();
			for (int i = 0; i < InitialBees; i++)
			{
				AddBee(random);
			}
		}

		public double Honey { get; private set; }

		public bool AddHoney(double nectar)
		{
			double honeyToAdd = nectar * NectarHoneyRatio;
			if (honeyToAdd + Honey > MaxHoney)
			{
				return false;
			}

			Honey += honeyToAdd;
			return true;
		}

		public bool ConsumeHoney(double amount)
		{
			if (amount > Honey)
			{
				return false;
			}

			Honey -= amount;
			return true;
		}

		public void Go(Random random)
		{
			if (_world.Bees.Count < MaxBees && Honey > MinimumHoneyForCreatingBees && random.Next(10) == 1)
			{
				AddBee(random);
			}
		}

		public Point GetLocation(string location) => _locations.Keys.Contains(location)
				? _locations[location]
				: throw new ArgumentException("Nie znaleziono takiej lokalizacji: " + location);

		private void InitializeLocations() => _locations = new Dictionary<string, Point>() {
				{ "Wejście", new Point(714, 149) },
				{ "Żłobek", new Point(144, 292) },
				{ "Fabryka miodu", new Point(274, 155) },
				{ "Wyjście", new Point(307, 361) }
			};

		private void AddBee(Random random)
		{
			_beeCount++;
			int r1 = random.Next(100) - 50;
			int r2 = random.Next(100) - 50;
			Point startPoint = new Point(_locations["Żłobek"].X + r1, _locations["Żłobek"].Y + r2);
			Bee newBee = new Bee(_beeCount, startPoint, this, _world);
			newBee.MessageSender += this.MessageSender;
			_world.Bees.Add(newBee);
		}
	}
}