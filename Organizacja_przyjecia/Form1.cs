using System;
using System.Windows.Forms;

namespace Organizacja_przyjecia
{
	public partial class Form1 : Form
	{
		private readonly DinnerParty dinnerParty;

		public Form1()
		{
			InitializeComponent();

			dinnerParty = new DinnerParty((int)NmNumberOfPeople.Value, ChHealthyOption.Checked, ChDecoration.Checked);
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal Cost = dinnerParty.CalculateCost(ChHealthyOption.Checked);
			LbTotalCost.Text = Cost.ToString("c");
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
	}
}