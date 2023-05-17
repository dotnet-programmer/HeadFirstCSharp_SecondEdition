using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa
{
	internal abstract class Weapon : Mover
	{
		//protected Game game;

		private bool pickedUp;
		public bool PickedUp => pickedUp;

		//private Point location;
		//public Point Location { get => location; }

		//public Weapon(Game game, Point location)
		public Weapon(Game game, Point location) : base(game, location) =>
			//this.game = game;
			//this.location = location;
			pickedUp = false;

		public void PickUpWeapon() => pickedUp = true;

		public abstract string Name { get; }

		public abstract void Attack(Direction direction, Random random, Stats stats);

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