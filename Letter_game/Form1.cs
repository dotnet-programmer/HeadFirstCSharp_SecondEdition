using System;
using System.Windows.Forms;

namespace Letter_game
{
	public partial class Form1 : Form
	{
		private readonly Random _random = new Random();
		private readonly Stats _stats = new Stats();

		public Form1()
			=> InitializeComponent();

		private void timer1_Tick(object sender, EventArgs e)
		{
			listBox1.Items.Add((Keys)_random.Next(65, 90));
			if (listBox1.Items.Count > 7)
			{
				listBox1.Items.Clear();
				listBox1.Items.Add("Koniec gry");
				timer1.Stop();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (listBox1.Items.Contains(e.KeyCode))
			{
				listBox1.Items.Remove(e.KeyCode);
				listBox1.Refresh();
				if (timer1.Interval > 400)
				{
					timer1.Interval -= 10;
				}

				if (timer1.Interval > 250)
				{
					timer1.Interval -= 7;
				}

				if (timer1.Interval > 100)
				{
					timer1.Interval -= 2;
				}

				difficultyProgressBar.Value = 800 - timer1.Interval;

				_stats.Update(true);
			}
			else
			{
				_stats.Update(false);
			}

			CorrectLabel.Text = "Prawidłowych: " + _stats.Correct;
			missedLabel.Text = "Błędów: " + _stats.Missed;
			totalLabel.Text = "Wszystkich: " + _stats.Total;
			accuracyLabel.Text = "Dokładność: " + _stats.Accuracy + "%";
		}
	}
}