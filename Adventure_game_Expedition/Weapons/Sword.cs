using System;
using System.Drawing;

namespace Adventure_game_Expedition.Weapons
{
	internal class Sword : Weapon
	{
		private const int _damage = 3;
		private const int _range = 25;

		public Sword(Game game, Point location) : base(game, location)
		{
		}

		public override string Name 
			=> "Miecz";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			switch (direction)
			{
				case Direction.Up:
					if (!DamageEnemy(Direction.Up, _range, _damage, random, stats))
					{
						if (!DamageEnemy(Direction.Right, _range, _damage, random, stats))
						{
							DamageEnemy(Direction.Left, _range, _damage, random, stats);
						}
					}
					break;
				case Direction.Down:
					if (!DamageEnemy(Direction.Down, _range, _damage, random, stats))
					{
						if (!DamageEnemy(Direction.Left, _range, _damage, random, stats))
						{
							DamageEnemy(Direction.Right, _range, _damage, random, stats);
						}
					}
					break;
				case Direction.Left:
					if (!DamageEnemy(Direction.Left, _range, _damage, random, stats))
					{
						if (!DamageEnemy(Direction.Up, _range, _damage, random, stats))
						{
							DamageEnemy(Direction.Down, _range, _damage, random, stats);
						}
					}
					break;
				case Direction.Right:
					if (!DamageEnemy(Direction.Right, _range, _damage, random, stats))
					{
						if (!DamageEnemy(Direction.Down, _range, _damage, random, stats))
						{
							DamageEnemy(Direction.Up, _range, _damage, random, stats);
						}
					}
					break;
				default:
					break;
			}
		}
	}
}