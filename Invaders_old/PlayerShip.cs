using System.Drawing;

namespace Invaders
{
	internal class PlayerShip
	{
		public Point Location { get; private set; }

		//public Rectangle Area { get { return new Rectangle(Location, image.Size); } }

		public bool Alive { get; set; }

		public void Draw(Graphics g)
		{
			if (!Alive)
			{
				// przywroc poczatkowa wartosc deadShipHeight i narysuj statek
			}
			else
			{
				// sprawdz pole deadShipHeight. Jezeli jego wartocs jest wieksza niz zero, zmniejsz ja o 1 i uzyj DrawImage() w celu narysowania statku nieco splaszczonego
			}
		}

		public void Move(Direction direction)
		{
		}
	}
}