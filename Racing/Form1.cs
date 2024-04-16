using System;
using System.Windows.Forms;

namespace Racing
{
	public partial class Form1 : Form
	{
		private const int MaxDogs = 4;
		private const int MaxGuys = 3;

		private readonly Greyhound[] _greyhounds = new Greyhound[MaxDogs];
		private readonly Guy[] _guys = new Guy[MaxGuys];
		private readonly Random _random = new Random();

		public Form1()
		{
			InitializeComponent();

			LbMinValue.Text += NmCash.Minimum + " zł";

			_greyhounds[0] = new Greyhound() { StartingPosition = PbDog1.Location.X, RacetrackLength = PbRacetrack.Right - PbDog1.Width, MyPictureBox = PbDog1, MyRandom = _random };
			_greyhounds[1] = new Greyhound() { StartingPosition = PbDog2.Location.X, RacetrackLength = PbRacetrack.Right - PbDog2.Width, MyPictureBox = PbDog2, MyRandom = _random };
			_greyhounds[2] = new Greyhound() { StartingPosition = PbDog3.Location.X, RacetrackLength = PbRacetrack.Right - PbDog3.Width, MyPictureBox = PbDog3, MyRandom = _random };
			_greyhounds[3] = new Greyhound() { StartingPosition = PbDog4.Location.X, RacetrackLength = PbRacetrack.Right - PbDog4.Width, MyPictureBox = PbDog4, MyRandom = _random };

			_guys[0] = new Guy() { Cash = 50, Name = "Janek", MyRadioButton = RbGuy1, MyLabel = LbGuy1, MyBet = null };
			_guys[1] = new Guy() { Cash = 75, Name = "Bartek", MyRadioButton = RbGuy2, MyLabel = LbGuy2, MyBet = null };
			_guys[2] = new Guy() { Cash = 45, Name = "Arek", MyRadioButton = RbGuy3, MyLabel = LbGuy3, MyBet = null };

			_guys[0].UpdateLabels();
			_guys[1].UpdateLabels();
			_guys[2].UpdateLabels();
		}

		private void BtnGetBet_Click(object sender, EventArgs e)
		{
			int numberOfGuy = 0;

			if (RbGuy1.Checked)
			{
				numberOfGuy = 0;
			}
			else if (RbGuy2.Checked)
			{
				numberOfGuy = 1;
			}
			else if (RbGuy3.Checked)
			{
				numberOfGuy = 2;
			}

			if (!_guys[numberOfGuy].PlaceBet((int)NmCash.Value, (int)NmDog.Value))
			{
				MessageBox.Show("Koleś nie ma wystarczającej ilości pieniędzy!");
			}

			_guys[numberOfGuy].UpdateLabels();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			SetButtons(false);
			bool stop = false;
			while (!stop)
			{
				for (int i = 0; i < MaxDogs; i++)
				{
					System.Threading.Thread.Sleep(2);
					if (_greyhounds[i].Run())
					{
						stop = true;
						MessageBox.Show("Mamy zwycięzcę - chart numer " + (i + 1));
						for (int j = 0; j < MaxGuys; j++)
						{
							_guys[j].Collect(i);
						}

						for (int j = 0; j < MaxGuys; j++)
						{
							_guys[j].UpdateLabels();
						}

						PbRacetrack.Update();
						break;
					}
					PbRacetrack.Update();
				}
			}
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < MaxDogs; i++)
			{
				_greyhounds[i].TakeStartingPosition();
			}

			for (int j = 0; j < MaxGuys; j++)
			{
				_guys[j].ClearBet();
			}

			for (int j = 0; j < MaxGuys; j++)
			{
				_guys[j].UpdateLabels();
			}

			SetButtons(true);
		}

		private void SetButtons(bool isEnabled)
			=> BtnStart.Enabled = BtnGetBet.Enabled = RbGuy1.Enabled = RbGuy2.Enabled = RbGuy3.Enabled = NmCash.Enabled = NmDog.Enabled = isEnabled;
	}
}