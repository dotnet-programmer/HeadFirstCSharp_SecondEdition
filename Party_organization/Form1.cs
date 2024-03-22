using System;
using System.Windows.Forms;

namespace Party_organization
{
	public partial class Form1 : Form
	{
		private readonly DinnerParty _dinnerParty;

		public Form1()
		{
			InitializeComponent();

			_dinnerParty = new DinnerParty((int)NmNumberOfPeople.Value, ChHealthyOption.Checked, ChDecoration.Checked);
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal Cost = _dinnerParty.CalculateCost(ChHealthyOption.Checked);
			LbTotalCost.Text = Cost.ToString("c");
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
	}
}