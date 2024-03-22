using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_go_fishing
{
	public partial class Form1 : Form
	{
		private Game _game;

		public Form1() 
			=> InitializeComponent();

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textName.Text))
			{
				MessageBox.Show("Wpisz swoje imię", "Nie można jeszcze rozpocząć gry");
				return;
			}

			_game = new Game(textName.Text, new List<string> { "Janek", "Bartek" }, textProgress);

			buttonStart.Enabled = textName.Enabled = false;
			buttonAsk.Enabled = true;
			UpdateForm();
		}

		private void buttonAsk_Click(object sender, EventArgs e)
		{
			textProgress.Text = "";
			if (listHand.SelectedIndex < 0)
			{
				MessageBox.Show("Wybierz kartę.");
				return;
			}
			if (_game.PlayOneRound(listHand.SelectedIndex))
			{
				textProgress.Text += "Zwycięzcą jest... " + _game.GetWinnerName();
				textBooks.Text = _game.DescribeBooks();
				buttonAsk.Enabled = false;
			}
			else
			{
				UpdateForm();
			}
		}

		private void UpdateForm()
		{
			listHand.Items.Clear();
			foreach (var item in _game.GetPlayerCardNames())
			{
				listHand.Items.Add(item);
			}

			textBooks.Text = _game.DescribeBooks();
			textProgress.Text += _game.DescribePlayerHands();
			textProgress.SelectionStart = textProgress.Text.Length;
			textProgress.ScrollToCaret();
		}
	}
}