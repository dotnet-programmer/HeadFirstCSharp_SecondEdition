using System;
using System.Windows.Forms;

namespace Gra_przygodowa_Wyprawa
{
	public partial class ChoosePlayerForm : Form
	{
		private string playerName;
		public string PlayerName => playerName;

		public ChoosePlayerForm() => InitializeComponent();

		private void BtnCancel_Click(object sender, EventArgs e) => Close();

		private void BtnStart_Click(object sender, EventArgs e) => StartGame();

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				StartGame();
			}

			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void StartGame()
		{
			if (string.IsNullOrWhiteSpace(TextPlayerName.Text))
			{
				MessageBox.Show("Podaj imie!");
				return;
			}
			playerName = TextPlayerName.Text;
			DialogResult = DialogResult.OK;
		}
	}
}