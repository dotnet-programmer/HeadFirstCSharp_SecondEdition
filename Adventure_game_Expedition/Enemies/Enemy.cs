using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal abstract class Enemy : Mover
	{
		private const int NearPlayerDistance = 25;

		private int _hitPoints;

		public Enemy(Game game, Point location, int hitPoints) : base(game, location)
			=> _hitPoints = hitPoints;

		public int HitPoints 
			=> _hitPoints;

		public bool Dead 
			=> _hitPoints <= 0;

		public abstract void Move(Random random);

		public void Hit(int maxDamage, Random random) 
			=> _hitPoints -= random.Next(1, maxDamage);

		protected bool NearPlayer() 
			=> (Nearby(game.PlayerLocation, NearPlayerDistance));

		protected Direction FindPlayerDirection(Point playerLocation)
		{
			Direction directionToMove = playerLocation.X > location.X + 10
				? Direction.Right
				: playerLocation.X < location.X - 10 ? Direction.Left : playerLocation.Y < location.Y - 10 ? Direction.Up : Direction.Down;
			return directionToMove;
		}
	}
}