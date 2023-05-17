using System;
using System.Windows.Forms;

namespace Walnij_Kreta
{
	internal class Mole
	{
		public delegate void PopUp(int hole, bool show);

		private readonly PopUp popUpCallback;

		private bool hidden;
		public bool Hidden => hidden;

		private int timesHit = 0;
		private int timesShown = 0;
		private int hole = 0;
		private readonly Random random;

		public Mole(Random random, PopUp popUpCallback)
		{
			if (popUpCallback == null)
			{
				throw new ArgumentException("popUpCallback nie możę przyjmować wartości null.");
			}

			this.random = random;
			this.popUpCallback = popUpCallback;
			hidden = true;
		}

		public void Show()
		{
			timesShown++;
			hidden = false;
			hole = random.Next(5);
			popUpCallback(hole, true);
		}

		public void HideAgain()
		{
			hidden = true;
			popUpCallback(hole, false);
			CheckForGameOver();
		}

		public void Smacked(int holeSmacked)
		{
			if (holeSmacked == hole)
			{
				timesHit++;
				hidden = true;
				CheckForGameOver();
				popUpCallback(hole, false);
			}
		}

		private void CheckForGameOver()
		{
			if (timesShown >= 10)
			{
				popUpCallback(-1, false);
				MessageBox.Show("Zdobyte punkty: " + timesHit, "Koniec gry");
				Application.Exit();
			}
		}
	}
}