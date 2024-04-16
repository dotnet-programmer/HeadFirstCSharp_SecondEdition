using System;
using System.Drawing;
using System.Windows.Forms;

namespace Racing
{
	internal class Greyhound
	{
		public int StartingPosition { get; set; }
		public int RacetrackLength { get; set; }
		public int Location { get; set; }
		public Random MyRandom { get; set; }
		public PictureBox MyPictureBox { get; set; } = null;

		public bool Run()
		{
			int distance = MyRandom.Next(1, 6);
			Point p = MyPictureBox.Location;
			p.X += distance;
			MyPictureBox.Location = p;

			return MyPictureBox.Location.X > RacetrackLength;
		}

		public void TakeStartingPosition()
		{
			Point p = MyPictureBox.Location;
			p.X = StartingPosition;
			MyPictureBox.Location = p;
		}
	}
}