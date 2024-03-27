using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal abstract class Weapon : Mover
	{
		private bool _pickedUp;

		public Weapon(Game game, Point location) : base(game, location)
			=> _pickedUp = false;

		public bool PickedUp
			=> _pickedUp;

		public abstract string Name { get; }

		public abstract void Attack(Direction direction, Random random, Stats stats);

		public void PickUpWeapon()
			=> _pickedUp = true;

		protected bool DamageEnemy(Direction direction, int radius, int damage, Random random, Stats stats)
		{
			Point target = game.PlayerLocation;
			for (int distance = 0; distance < radius; distance++)
			{
				foreach (var item in game.Enemies)
				{
					if (Nearby(item.Location, target, radius))
					{
						item.Hit(damage, random);
						if (item.Dead)
						{
							stats.KilledEnemies++;
						}
						return true;
					}
				}
				target = Move(direction, target, game.Boundaries);
			}
			return false;
		}
	}
}