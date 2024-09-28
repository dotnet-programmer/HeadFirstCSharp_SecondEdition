using System;
using System.Windows.Forms;

namespace Hit_mole
{
	internal class Mole
	{
		public delegate void PopUp(int hole, bool show);

		private readonly PopUp _popUpCallback;
		private readonly Random _random;

		private bool _hidden;
		private int _timesHit = 0;
		private int _timesShown = 0;
		private int _hole = 0;

		public Mole(Random random, PopUp popUpCallback)
		{
			if (popUpCallback == null)
			{
				throw new ArgumentException("popUpCallback nie może przyjmować wartości null.");
			}

			_random = random;
			_popUpCallback = popUpCallback;
			_hidden = true;
		}

		public bool Hidden
			=> _hidden;

		public void Show()
		{
			_timesShown++;
			_hidden = false;
			_hole = _random.Next(5);
			_popUpCallback(_hole, true);
		}

		public void HideAgain()
		{
			_hidden = true;
			_popUpCallback(_hole, false);
			CheckForGameOver();
		}

		public void Smacked(int holeSmacked)
		{
			if (holeSmacked == _hole)
			{
				_timesHit++;
				_hidden = true;
				CheckForGameOver();
				_popUpCallback(_hole, false);
			}
		}

		private void CheckForGameOver()
		{
			if (_timesShown >= 10)
			{
				_popUpCallback(-1, false);
				MessageBox.Show("Zdobyte punkty: " + _timesHit, "Koniec gry");
				Application.Exit();
			}
		}
	}
}