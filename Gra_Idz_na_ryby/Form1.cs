using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gra_Idz_na_ryby
{
	public partial class Form1 : Form
	{
		private Game game;

		public Form1() => InitializeComponent();

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textName.Text))
			{
				MessageBox.Show("Wpisz swoje imię", "Nie można jeszcze rozpocząć gry");
				return;
			}

			game = new Game(textName.Text, new List<string> { "Janek", "Bartek" }, textProgress);

			buttonStart.Enabled = textName.Enabled = false;
			buttonAsk.Enabled = true;
			UpdateForm();
		}

		private void UpdateForm()
		{
			listHand.Items.Clear();
			foreach (var item in game.GetPlayerCardNames())
			{
				listHand.Items.Add(item);
			}

			textBooks.Text = game.DescribeBooks();
			textProgress.Text += game.DescribePlayerHands();
			textProgress.SelectionStart = textProgress.Text.Length;
			textProgress.ScrollToCaret();
		}

		private void buttonAsk_Click(object sender, EventArgs e)
		{
			textProgress.Text = "";
			if (listHand.SelectedIndex < 0)
			{
				MessageBox.Show("Wybierz kartę.");
				return;
			}
			if (game.PlayOneRound(listHand.SelectedIndex))
			{
				textProgress.Text += "Zwycięzcą jest... " + game.GetWinnerName();
				textBooks.Text = game.DescribeBooks();
				buttonAsk.Enabled = false;
			}
			else
			{
				UpdateForm();
			}
		}
	}
}