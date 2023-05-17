using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dzien_na_wyscigach
{
	internal class Greyhound
	{
		public int StartingPosition; // miejsce, gdzie ropoczyna sie pictureBox
		public int RacetrackLength;  // jak dluga jest trasa
		public int Location = 0; // moje polozenie na torze wyscigowym
		public Random MyRandom; // instancja klasy Random

		public PictureBox MyPictureBox = null; // moj obrazek picturePox

		public bool Run()
		{
			// przesun sie do przodu losowo o 1, 2, 3, 4 punkty
			// zaktualizuj polozenie pictureBox na formularzu
			int distance = MyRandom.Next(1, 6);
			Point p = MyPictureBox.Location;
			p.X += distance;
			MyPictureBox.Location = p;

			// zwroc true, jezeli wygralem wyscig
			return MyPictureBox.Location.X > RacetrackLength;
		}

		public void TakeStartingPosition()
		{
			// wyzeruj polozenie i ustaw na linii startowej
			Point p = MyPictureBox.Location;
			p.X = StartingPosition;
			MyPictureBox.Location = p;
		}
	}
}