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
		/// Start new game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Show stats
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnStats_Click(object sender, EventArgs e)
		{
			using (StatsForm statsForm = new StatsForm(_stats))
			{
				statsForm.ShowDialog();
			}
		}

		/// <summary>
		/// Exit game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnExit_Click(object sender, EventArgs e)
			=> Application.Exit();

		/// <summary>
		/// Start new game
		/// </summary>
		/// <param name="playerName">Player name</param>
		private void StartGame(string playerName)
		{
			Visible = false;
			using (GameForm gameForm = new GameForm(playerName, _stats))
			{
				gameForm.ShowDialog();
			}
			Visible = true;
		}
	}
}