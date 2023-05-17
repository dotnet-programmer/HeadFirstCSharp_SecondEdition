﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Symulator_ula
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

		private Dictionary<string, Point> locations;
		private int beeCount = 0;
		private readonly World world;

		[NonSerialized]
		public BeeMessage MessageSender;

		public double Honey { get; private set; }

		public Hive(World world, BeeMessage MessageSender)
		{
			this.MessageSender = MessageSender;
			this.world = world;
			Honey = InitialHoney;
			InitializeLocations();
			Random random = new Random();
			for (int i = 0; i < InitialBees; i++)
			{
				AddBee(random);
			}
		}

		private void InitializeLocations() => locations = new Dictionary<string, Point>() {
				{ "Wejście", new Point(714, 149) },
				{ "Żłobek", new Point(144, 292) },
				{ "Fabryka miodu", new Point(274, 155) },
				{ "Wyjście", new Point(307, 361) }
			};

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

		private void AddBee(Random random)
		{
			beeCount++;
			int r1 = random.Next(100) - 50;
			int r2 = random.Next(100) - 50;
			Point startPoint = new Point(locations["Żłobek"].X + r1, locations["Żłobek"].Y + r2);
			Bee newBee = new Bee(beeCount, startPoint, this, world);
			newBee.MessageSender += this.MessageSender;
			world.Bees.Add(newBee);
		}

		public void Go(Random random)
		{
			if (world.Bees.Count < MaxBees && Honey > MinimumHoneyForCreatingBees && random.Next(10) == 1)
			{
				AddBee(random);
			}
		}

		public Point GetLocation(string location) => locations.Keys.Contains(location)
				? locations[location]
				: throw new ArgumentException("Nie znaleziono takiej lokalizacji: " + location);
	}
}