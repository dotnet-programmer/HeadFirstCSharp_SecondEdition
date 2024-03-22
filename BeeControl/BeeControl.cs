using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeeControl
{
	internal class BeeControl : PictureBox
	{
		private readonly Timer _animationTimer = new Timer();
		private int _cell = 0;
		private readonly Random _random = new Random();
		private Rectangle _boundaries = new Rectangle(50, 50, 650, 350);
		private readonly int _moveInterval = 50;

		public BeeControl()
		{
			_animationTimer.Tick += AnimationTimer_Tick;
			_animationTimer.Interval = 80;
			_animationTimer.Start();
			BackColor = Color.Transparent;
			BackgroundImageLayout = ImageLayout.Zoom;
			Size = new Size(200, 200);
		}

		private void AnimationTimer_Tick(object sender, EventArgs e)
		{
			_cell++;
			switch (_cell)
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
					_cell = 0;
					break;
			}

			Direction direction = (Direction)_random.Next(4);
			Point newLocation = Location;
			switch (direction)
			{
				case Direction.Up:
					if (newLocation.Y - _moveInterval >= _boundaries.Top)
					{
						newLocation.Y -= _moveInterval;
					}
					break;
				case Direction.Down:
					if (newLocation.Y + _moveInterval <= _boundaries.Bottom)
					{
						newLocation.Y += _moveInterval;
					}
					break;
				case Direction.Left:
					if (newLocation.X - _moveInterval >= _boundaries.Left)
					{
						newLocation.X -= _moveInterval;
					}
					break;
				case Direction.Right:
					if (newLocation.X + _moveInterval <= _boundaries.Right)
					{
						newLocation.X += _moveInterval;
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
				_animationTimer.Dispose();
			}
		}
	}
}