using System;
using System.Windows.Forms;

namespace Adventure_game_Expedition
{
	public partial class ChoosePlayerForm : Form
	{
		public ChoosePlayerForm()
			=> InitializeComponent();

		public string PlayerName { get; private set; }

		private void BtnStart_Click(object sender, EventArgs e)
			=> StartGame();

		private void BtnCancel_Click(object sender, EventArgs e)
			=> Close();

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				StartGame();
			}
			else if (e.KeyCode == Keys.Escape)
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
			PlayerName = TextPlayerName.Text;
			DialogResult = DialogResult.OK;
		}
	}
}