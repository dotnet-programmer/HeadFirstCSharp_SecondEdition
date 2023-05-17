using System;
using System.Drawing;

namespace Invaders
{
	internal class Invader
	{
		private const int HorizontalInterval = 10;
		private const int VerticalInterval = 40;

		private readonly Bitmap image;

		public Point Location { get; private set; }

		public Type InvaderType { get; private set; }

		public Rectangle Area => new Rectangle(Location, image.Size);

		public int Score { get; private set; }

		public Invader(Type invaderType, Point location, int score)
		{
			this.InvaderType = invaderType;
			this.Location = location;
			this.Score = score;
			//image = InvaderImage(0);
		}

		public void Move(Direction direction)
		{
			// przeniesienie statku w okreslonym kierunku
		}

		public void Draw(Graphics g, int animationCell)
		{
			// rysuje obrazek statku wykorzystujac wlasciwa klatke animacji
		}

		public void InvaderImage(int animationCell)
		{
			// metoda pomocnicza, zwraca wlasciwa bitmape na podstawie przekazanego numeru klatki animacji
		}
	}
}