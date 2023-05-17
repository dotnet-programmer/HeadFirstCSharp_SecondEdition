﻿using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa.Weapons
{
	internal class Bow : Weapon
	{
		public Bow(Game game, Point location) : base(game, location)
		{
		}

		public override string Name => "Łuk";

		public override void Attack(Direction direction, Random random, Stats stats) => DamageEnemy(direction, 50, 1, random, stats);
	}
}