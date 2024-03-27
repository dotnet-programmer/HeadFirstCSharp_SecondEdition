using System;
using System.Drawing;

namespace Adventure_game_Expedition.Weapons
{
	internal class Sword : Weapon
	{
		private const int Damage = 3;
		private const int Range = 25;

		public Sword(Game game, Point location) : base(game, location)
		{
		}

		public override string Name
			=> WeaponName.Sword;

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			switch (direction)
			{
				case Direction.Up:
					if (!DamageEnemy(Direction.Up, Range, Damage, random, stats))
					{
						if (!DamageEnemy(Direction.Right, Range, Damage, random, stats))
						{
							DamageEnemy(Direction.Left, Range, Damage, random, stats);
						}
					}
					break;
				case Direction.Down:
					if (!DamageEnemy(Direction.Down, Range, Damage, random, stats))
					{
						if (!DamageEnemy(Direction.Left, Range, Damage, random, stats))
						{
							DamageEnemy(Direction.Right, Range, Damage, random, stats);
						}
					}
					break;
				case Direction.Left:
					if (!DamageEnemy(Direction.Left, Range, Damage, random, stats))
					{
						if (!DamageEnemy(Direction.Up, Range, Damage, random, stats))
						{
							DamageEnemy(Direction.Down, Range, Damage, random, stats);
						}
					}
					break;
				case Direction.Right:
					if (!DamageEnemy(Direction.Right, Range, Damage, random, stats))
					{
						if (!DamageEnemy(Direction.Down, Range, Damage, random, stats))
						{
							DamageEnemy(Direction.Up, Range, Damage, random, stats);
						}
					}
					break;
				default:
					break;
			}
		}
	}
}