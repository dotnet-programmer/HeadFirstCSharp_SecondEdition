using System.Windows.Forms;

namespace Gra_przygodowa_Wyprawa
{
	public partial class StatsForm : Form
	{
		public StatsForm(Stats stats)
		{
			InitializeComponent();

			ValueGamesCount.Text = stats.GamesCount.ToString();
			ValueWin.Text = stats.Win.ToString();
			ValueLose.Text = stats.Lose.ToString();
			ValueKilledEnemies.Text = stats.KilledEnemies.ToString();
			ValueFindItems.Text = stats.FindItems.ToString();
			ValueDrinkPotions.Text = stats.DrinkPotions.ToString();
		}
	}
}