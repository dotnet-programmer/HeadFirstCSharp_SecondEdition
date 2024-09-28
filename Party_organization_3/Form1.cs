using System;
using System.Windows.Forms;

namespace Party_organization_3
{
	public partial class Form1 : Form
	{
		private const int foodCost = 25;
		private const decimal fantasyDecorationCost = 15M;
		private const decimal fantasyDecorationConst = 50M;
		private const decimal normalDecorationCost = 7.50M;
		private const decimal normalDecorationConst = 30M;
		private const decimal healthyOptionCost = 5M;
		private const decimal healthyOptionDiscount = 0.95M;
		private const decimal alcoholOptionCost = 20;

		private const int smallCakeSize = 20;
		private const decimal smallCakeCost = 40M;
		private const int largeCakeSize = 40;
		private const decimal largeCakeCost = 75M;
		private const decimal letterCost = 0.25M;
		private const int smallCakeMaxLetters = 16;
		private const int largeCakeMaxLetters = 40;

		public Form1()
			=> InitializeComponent();

		private void NormalPartyValueChanged(object sender, EventArgs e)
			=> LbTotalCost.Text = CalculateCost(true, (int)NmNumberOfPeople.Value, ChDecoration.Checked, ChHealthyOption.Checked).ToString();

		private void BirthdayPartyValueChanged(object sender, EventArgs e)
			=> LbTotalCostBth.Text = CalculateCost(false, (int)NmNumberOfPeopleBth.Value, ChDecorationBth.Checked).ToString();

		private decimal CalculateCost(bool isNormal, int numberOfPeople, bool isDecoration, bool isHealthy = false)
		{
			decimal totalCost = numberOfPeople * foodCost;

			if (isDecoration)
			{
				totalCost += numberOfPeople * fantasyDecorationCost + fantasyDecorationConst;
			}
			else
			{
				totalCost += numberOfPeople * normalDecorationCost + normalDecorationConst;
			}

			if (isNormal)
			{
				if (isHealthy)
				{
					totalCost += numberOfPeople * healthyOptionCost;
					totalCost *= healthyOptionDiscount;
				}
				else
				{
					totalCost += numberOfPeople * alcoholOptionCost;
				}
			}
			else
			{
				int howManyLetters = TxtCakeWriting.Text.Length;

				if (numberOfPeople > 4)
				{
					if (howManyLetters > largeCakeMaxLetters)
					{
						MessageBox.Show("Tekst za długi! zostanie ucięty do {0} znaków", largeCakeMaxLetters.ToString());
						totalCost += largeCakeCost + largeCakeMaxLetters * letterCost;
					}
					else
					{
						totalCost += largeCakeCost + howManyLetters * letterCost;
					}
				}
				else
				{
					if (howManyLetters > smallCakeMaxLetters)
					{
						MessageBox.Show("Tekst za długi! zostanie ucięty do {0} znaków", smallCakeMaxLetters.ToString());
						totalCost += largeCakeCost + smallCakeMaxLetters * letterCost;
					}
					else
					{
						totalCost += smallCakeCost + howManyLetters * letterCost;
					}
				}
			}

			return totalCost;
		}
	}
}