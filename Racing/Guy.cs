using System.Windows.Forms;

namespace Racing
{
	internal class Guy
	{
		public string Name { get; set; }
		public int Cash { get; set; }
		public Bet MyBet { get; set; }

		public RadioButton MyRadioButton { get; set; }
		public Label MyLabel { get; set; }

		public void UpdateLabels()
		{
			MyLabel.Text = MyBet != null ? MyBet.GetDescription() : Name + " nie zawarł zakładu";
			MyRadioButton.Text = Name + " ma " + Cash + " zł";
		}

		public void ClearBet()
			=> MyBet = null;

		public bool PlaceBet(int Amount, int Dog)
		{
			if (Cash >= Amount)
			{
				MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Collect(int Winner)
		{
			if (MyBet != null)
			{
				Cash += MyBet.PayOut(Winner + 1);
			}
		}
	}
}