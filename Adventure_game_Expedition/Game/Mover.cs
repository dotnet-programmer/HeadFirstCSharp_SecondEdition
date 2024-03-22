using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal abstract class Mover
	{
		private const int MoveInterval = 10;
		protected Game game;
		protected Point location;

		public Mover(Game game, Point location)
		{
			this.game = game;
			this.location = location;
		}

		public Point Location 
			=> location;

		public bool Nearby(Point locationToCheck, int distance) 
			=> Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(location.Y - locationToCheck.Y) < distance);

		public bool Nearby(Point location1, Point location2, int distance) 
			=> Math.Abs(location1.X - location2.X) < distance && (Math.Abs(location1.Y - location2.Y) < distance);

		public Point Move(Direction direction, Rectangle boundaries)
		{
			Point newLocation = location;
			switch (direction)
			{
				case Direction.Up:
					if (newLocation.Y - MoveInterval >= boundaries.Top)
					{
						newLocation.Y -= MoveInterval;
					}
					break;
				case Direction.Down:
					if (newLocation.Y + MoveInterval <= boundaries.Bottom)
					{
						newLocation.Y += MoveInterval;
					}
					break;
				case Direction.Left:
					if (newLocation.X - MoveInterval >= boundaries.Left)
					{
						newLocation.X -= MoveInterval;
					}
					break;
				case Direction.Right:
					if (newLocation.X + MoveInterval <= boundaries.Right)
					{
						newLocation.X += MoveInterval;
					}
					break;
				default: break;
			}
			return newLocation;
		}

		public Point Move(Direction direction, Point target, Rectangle boundaries)
		{
			int moveInterval = 1;
			Point newLocation = target;
			switch (direction)
			{
				case Direction.Up:
					if (newLocation.Y - moveInterval >= boundaries.Top)
					{
						newLocation.Y -= moveInterval;
					}
					break;
				case Direction.Down:
					if (newLocation.Y + moveInterval <= boundaries.Bottom)
					{
						newLocation.Y += moveInterval;
					}
					break;
				case Direction.Left:
					if (newLocation.X - moveInterval >= boundaries.Left)
					{
						newLocation.X -= moveInterval;
					}
					break;
				case Direction.Right:
					if (newLocation.X + moveInterval <= boundaries.Right)
					{
						newLocation.X += moveInterval;
					}
					break;
				default: break;
			}
			return newLocation;
		}
	}
}