using System;
using System.Windows.Forms;

namespace Organizacja_przyjecia_2
{
	public partial class Form1 : Form
	{
		private readonly DinnerParty dinnerParty;
		private readonly BirthdayParty birthdayParty;

		public Form1()
		{
			InitializeComponent();

			dinnerParty = new DinnerParty((int)NmNumberOfPeople.Value, ChHealthyOption.Checked, ChDecoration.Checked);
			DisplayDinnerPartyCost();

			birthdayParty = new BirthdayParty((int)NmNumberOfPeopleBth.Value, ChDecorationBth.Checked, TxtCakeWriting.Text);
			DisplayBirthdayPartyCost();
		}

		private void NmNumberOfPeople_ValueChanged(object sender, EventArgs e)
		{
			dinnerParty.NumberOfPeople = (int)NmNumberOfPeople.Value;
			DisplayDinnerPartyCost();
		}

		private void ChDecoration_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.CalculateCostOfDecorations(ChDecoration.Checked);
			DisplayDinnerPartyCost();
		}

		private void ChHealthyOption_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.SetHealthyOption(ChHealthyOption.Checked);
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal Cost = dinnerParty.CalculateCost(ChHealthyOption.Checked);
			LbTotalCost.Text = Cost.ToString("c");
		}

		private void NmNumberOfPeopleBth_ValueChanged(object sender, EventArgs e)
		{
			birthdayParty.NumberOfPeople = (int)NmNumberOfPeopleBth.Value;
			DisplayBirthdayPartyCost();
		}

		private void ChDecorationBth_CheckedChanged(object sender, EventArgs e)
		{
			birthdayParty.CalculateCostOfDecorations(ChDecorationBth.Checked);
			DisplayBirthdayPartyCost();
		}

		private void DisplayBirthdayPartyCost()
		{
			TxtCakeWriting.Text = birthdayParty.CakeWriting;
			decimal cost = birthdayParty.CalculateCost();
			LbTotalCostBth.Text = cost.ToString("c");
		}

		private void TxtCakeWriting_TextChanged(object sender, EventArgs e)
		{
			birthdayParty.CakeWriting = TxtCakeWriting.Text;
			DisplayBirthdayPartyCost();
		}
	}
}