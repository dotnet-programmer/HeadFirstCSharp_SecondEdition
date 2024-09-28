using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hit_mole
{
	public partial class Form1 : Form
	{
		private readonly Mole _mole;
		private readonly Random _random = new Random();

		public Form1()
		{
			InitializeComponent();

			_mole = new Mole(_random, new Mole.PopUp(MoleCallBack));
			timer1.Interval = _random.Next(500, 1000);
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			ToggleMole();
		}

		private void ToggleMole()
		{
			if (_mole.Hidden == true)
			{
				_mole.Show();
			}
			else
			{
				_mole.HideAgain();
			}

			timer1.Interval = _random.Next(500, 1000);
			timer1.Start();
		}

		private void MoleCallBack(int MoleNumber, bool Show)
		{
			if (MoleNumber < 0)
			{
				timer1.Stop();
				return;
			}

			Button button;
			switch (MoleNumber)
			{
				case 0: button = button1; break;
				case 1: button = button2; break;
				case 2: button = button3; break;
				case 3: button = button4; break;
				default: button = button5; break;
			}

			if (Show == true)
			{
				button.Text = "WALNIJ MNIE!";
				button.BackColor = Color.Red;
			}
			else
			{
				button.Text = "";
				button.BackColor = SystemColors.Control;
			}
			timer1.Interval = _random.Next(500, 1000);
			timer1.Start();
		}

		private void button1_Click(object sender, EventArgs e)
			=> _mole.Smacked(0);

		private void button2_Click(object sender, EventArgs e)
			=> _mole.Smacked(1);

		private void button3_Click(object sender, EventArgs e)
			=> _mole.Smacked(2);

		private void button4_Click(object sender, EventArgs e)
			=> _mole.Smacked(3);

		private void button5_Click(object sender, EventArgs e)
			=> _mole.Smacked(4);
	}
}