using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa
{
	internal abstract class Enemy : Mover
	{
		private const int NearPlayerDistance = 25;

		private int hitPoints;
		public int HitPoints => hitPoints;

		public bool Dead => hitPoints <= 0;

		public Enemy(Game game, Point location, int hitPoints) : base(game, location) => this.hitPoints = hitPoints;

		public abstract void Move(Random random);

		public void Hit(int maxDamage, Random random) => hitPoints -= random.Next(1, maxDamage);

		protected bool NearPlayer() => (Nearby(game.PlayerLocation, NearPlayerDistance));

		protected Direction FindPlayerDirection(Point playerLocation)
		{
			Direction directionToMove = playerLocation.X > location.X + 10
				? Direction.Right
				: playerLocation.X < location.X - 10 ? Direction.Left : playerLocation.Y < location.Y - 10 ? Direction.Up : Direction.Down;
			return directionToMove;
		}
	}
}