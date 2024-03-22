using System;
using System.Windows.Forms;

namespace Adventure_game_Expedition
{
	public partial class MainForm : Form
	{
		private readonly Stats _stats;

		public MainForm()
		{
			InitializeComponent();
			_stats = new Stats();
		}

		/// <summary>
		/// Start game
		/// </summary>
		public void StartGame(string playerName)
		{
			Visible = false;
			using (GameForm gameForm = new GameForm(_stats))
			{
				gameForm.PlayerName = playerName;
				gameForm.ShowDialog();
			}
			Visible = true;
		}

		// New game
		private void BtnNewGame_Click(object sender, EventArgs e)
		{
			bool isStartGame = false;
			string playerName = "";

			using (ChoosePlayerForm choosePlayerForm = new ChoosePlayerForm())
			{
				if (choosePlayerForm.ShowDialog() == DialogResult.OK)
				{
					playerName = choosePlayerForm.PlayerName;
					isStartGame = true;
				}
			}

			if (isStartGame)
			{
				StartGame(playerName);
			}
		}

		// Exit game
		private void BtnExit_Click(object sender, EventArgs e) 
			=> Application.Exit();

		// stats
		private void BtnStats_Click(object sender, EventArgs e)
		{
			using (StatsForm statsForm = new StatsForm(_stats))
			{
				statsForm.ShowDialog();
			}
		}
	}
}