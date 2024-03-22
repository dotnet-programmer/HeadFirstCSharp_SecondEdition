using System;
using System.Windows.Forms;

namespace Party_organization_2
{
	public partial class Form1 : Form
	{
		private readonly DinnerParty _dinnerParty;
		private readonly BirthdayParty _birthdayParty;

		public Form1()
		{
			InitializeComponent();

			_dinnerParty = new DinnerParty((int)NmNumberOfPeople.Value, ChHealthyOption.Checked, ChDecoration.Checked);
			DisplayDinnerPartyCost();

			_birthdayParty = new BirthdayParty((int)NmNumberOfPeopleBth.Value, ChDecorationBth.Checked, TxtCakeWriting.Text);
			DisplayBirthdayPartyCost();
		}

		private void NmNumberOfPeople_ValueChanged(object sender, EventArgs e)
		{
			_dinnerParty.NumberOfPeople = (int)NmNumberOfPeople.Value;
			DisplayDinnerPartyCost();
		}

		private void ChDecoration_CheckedChanged(object sender, EventArgs e)
		{
			_dinnerParty.CalculateCostOfDecorations(ChDecoration.Checked);
			DisplayDinnerPartyCost();
		}

		private void ChHealthyOption_CheckedChanged(object sender, EventArgs e)
		{
			_dinnerParty.SetHealthyOption(ChHealthyOption.Checked);
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal Cost = _dinnerParty.CalculateCost(ChHealthyOption.Checked);
			LbTotalCost.Text = Cost.ToString("c");
		}

		private void NmNumberOfPeopleBth_ValueChanged(object sender, EventArgs e)
		{
			_birthdayParty.NumberOfPeople = (int)NmNumberOfPeopleBth.Value;
			DisplayBirthdayPartyCost();
		}

		private void ChDecorationBth_CheckedChanged(object sender, EventArgs e)
		{
			_birthdayParty.CalculateCostOfDecorations(ChDecorationBth.Checked);
			DisplayBirthdayPartyCost();
		}

		private void DisplayBirthdayPartyCost()
		{
			TxtCakeWriting.Text = _birthdayParty.CakeWriting;
			decimal cost = _birthdayParty.CalculateCost();
			LbTotalCostBth.Text = cost.ToString("c");
		}

		private void TxtCakeWriting_TextChanged(object sender, EventArgs e)
		{
			_birthdayParty.CakeWriting = TxtCakeWriting.Text;
			DisplayBirthdayPartyCost();
		}
	}
}