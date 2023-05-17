using System.Drawing;

namespace Invaders
{
	internal class Shot
	{
		private const int moveInterval = 20;
		private const int width = 5;
		private const int height = 15;

		public Point Location { get; private set; }

		private readonly Direction direction;
		private Rectangle boundaries;

		public Shot(Point location, Direction direction, Rectangle boundaries)
		{
			this.Location = location;
			this.direction = direction;
			this.boundaries = boundaries;
		}

		// reszta kodu
	}
}