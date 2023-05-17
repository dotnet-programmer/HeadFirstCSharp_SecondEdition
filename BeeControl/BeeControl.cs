using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeeControl
{
	internal class BeeControl : PictureBox
	{
		private readonly Timer animationTimer = new Timer();
		private int cell = 0;
		private readonly Random random = new Random();
		private Rectangle boundaries = new Rectangle(50, 50, 650, 350);
		private readonly int MoveInterval = 50;

		public BeeControl()
		{
			animationTimer.Tick += AnimationTimer_Tick;
			animationTimer.Interval = 80;
			animationTimer.Start();
			BackColor = Color.Transparent;
			BackgroundImageLayout = ImageLayout.Zoom;
			Size = new Size(200, 200);
		}

		private void AnimationTimer_Tick(object sender, EventArgs e)
		{
			cell++;
			switch (cell)
			{
				case 1:
					BackgroundImage = Properties.Resources.Bee_animation_1;
					break;
				case 2:
					BackgroundImage = Properties.Resources.Bee_animation_2;
					break;
				case 3:
					BackgroundImage = Properties.Resources.Bee_animation_3;
					break;
				case 4:
					BackgroundImage = Properties.Resources.Bee_animation_4;
					break;
				case 5:
					BackgroundImage = Properties.Resources.Bee_animation_3;
					break;
				default:
					BackgroundImage = Properties.Resources.Bee_animation_2;
					cell = 0;
					break;
			}
			int X = Location.X;
			int Y = Location.Y;
			Direction direction = (Direction)random.Next(4);

			Point newLocation = Location;
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
			Location = newLocation;
		}

		private enum Direction
		{
			Up, Down, Left, Right
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				animationTimer.Dispose();
			}
		}
	}
}