using System;
using System.Collections.Generic;
using System.Drawing;

namespace Invaders
{
	internal class Stars
	{
		private struct Star
		{
			public Point point;
			public Pen pen;

			public Star(Point point, Pen pen)
			{
				this.point = point;
				this.pen = pen;
			}
		}

		private readonly List<Star> stars;

		public void Draw(Graphics g)
		{
		}

		public void Twinkle(Random random)
		{
		}

		private void RandomPen()
		{
			Random random = new Random();
			int color = random.Next(5);
		}
	}
}