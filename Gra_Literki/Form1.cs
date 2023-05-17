using System;
using System.Windows.Forms;

namespace Gra_Literki
{
	public partial class Form1 : Form
	{
		private readonly Random random = new Random();
		private readonly Stats stats = new Stats();

		public Form1() => InitializeComponent();

		private void timer1_Tick(object sender, EventArgs e)
		{
			// dodajemy losową literkę do kontrolki ListBox
			listBox1.Items.Add((Keys)random.Next(65, 90));
			if (listBox1.Items.Count > 7)
			{
				listBox1.Items.Clear();
				listBox1.Items.Add("Koniec gry");
				timer1.Stop();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// jeśli gracz nacisnął klawisz literki dostępnej w kontrolce ListBox, to usuwamy ją i zwiększamy tempo gry
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

				// gracz nacisnal prawidlowy klawisz, aktualizujemy zatem statystyki gry, wywołując metodę Update() i przekazując do niej wartość true
				stats.Update(true);
			}
			else
			{
				// gracz nacisnal niewlasciwy klawisz, zatem aktualizujemy statystyki przekazujac w wywolaniu Update() false
				stats.Update(false);
			}

			// aktualizacja etykiet na pasku stanu
			CorrectLabel.Text = "Prawidłowych: " + stats.Correct;
			missedLabel.Text = "Błędów: " + stats.Missed;
			totalLabel.Text = "Wszystkich: " + stats.Total;
			accuracyLabel.Text = "Dokładność: " + stats.Accuracy + "%";
		}
	}
}