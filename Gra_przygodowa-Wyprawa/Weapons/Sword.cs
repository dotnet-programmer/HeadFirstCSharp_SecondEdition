using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa.Weapons
{
	internal class Sword : Weapon
	{
		private const int damage = 3;
		private const int range = 25;

		public Sword(Game game, Point location) : base(game, location)
		{
		}

		public override string Name => "Miecz";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			switch (direction)
			{
				case Direction.Up:
					if (!DamageEnemy(Direction.Up, range, damage, random, stats))
					{
						if (!DamageEnemy(Direction.Right, range, damage, random, stats))
						{
							DamageEnemy(Direction.Left, range, damage, random, stats);
						}
					}

					break;
				case Direction.Down:
					if (!DamageEnemy(Direction.Down, range, damage, random, stats))
					{
						if (!DamageEnemy(Direction.Left, range, damage, random, stats))
						{
							DamageEnemy(Direction.Right, range, damage, random, stats);
						}
					}

					break;
				case Direction.Left:
					if (!DamageEnemy(Direction.Left, range, damage, random, stats))
					{
						if (!DamageEnemy(Direction.Up, range, damage, random, stats))
						{
							DamageEnemy(Direction.Down, range, damage, random, stats);
						}
					}

					break;
				case Direction.Right:
					if (!DamageEnemy(Direction.Right, range, damage, random, stats))
					{
						if (!DamageEnemy(Direction.Down, range, damage, random, stats))
						{
							DamageEnemy(Direction.Up, range, damage, random, stats);
						}
					}

					break;
				default:
					break;
			}
		}
	}
}