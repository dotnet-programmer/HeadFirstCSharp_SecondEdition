using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal abstract class Weapon : Mover
	{
		//protected Game game;

		private bool _pickedUp;
		//private Point location;
		//public Point Location { get => location; }

		//public Weapon(Game game, Point location)
		public Weapon(Game game, Point location) : base(game, location)
			=> _pickedUp = false;

		public bool PickedUp 
			=> _pickedUp;
		//this.game = game;
		//this.location = location;

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