﻿using System;
using System.Drawing;

namespace Hive_simulator_2
{
	[Serializable]
	public class Flower
	{
		private const int LifeSpanMin = 15000;
		private const int LifeSpanMax = 30000;
		private const double InitialNectar = 1.5;
		private const double MaxNectar = 5.0;
		private const double NectarAddedPerTurn = 0.01;
		private const double NectarGatheredPerTurn = 0.3;

		private readonly int _lifespan;

		public Flower(Point point, Random random)
		{
			Location = point;
			Age = 0;
			Alive = true;
			Nectar = InitialNectar;
			NectarHarvesed = 0;
			_lifespan = random.Next(LifeSpanMin, LifeSpanMax + 1);
		}

		public Point Location { get; private set; }
		public int Age { get; private set; }
		public bool Alive { get; private set; }
		public double Nectar { get; private set; }
		public double NectarHarvesed { get; set; }

		public double HarvestNectar()
		{
			if (NectarGatheredPerTurn > Nectar)
			{
				return 0;
			}
			else
			{
				Nectar -= NectarGatheredPerTurn;
				NectarHarvesed += NectarGatheredPerTurn;
				return NectarGatheredPerTurn;
			}
		}

		public void Go()
		{
			Age++;
			if (Age > _lifespan)
			{
				Alive = false;
			}
			else
			{
				Nectar += NectarAddedPerTurn;
				if (Nectar > MaxNectar)
				{
					Nectar = MaxNectar;
				}
			}
		}
	}
}