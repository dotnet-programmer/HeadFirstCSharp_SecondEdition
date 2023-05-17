using System.Windows.Forms;

namespace Organizacja_przyjecia_2
{
	internal class BirthdayParty
	{
		public const int CostOfFoodPerPerson = 25;
		public decimal CostOfDecorations = 0;
		private bool fancyDecorations;
		public int CakeSize;

		private int numberOfPeople;
		public int NumberOfPeople
		{
			get => numberOfPeople;
			set
			{
				numberOfPeople = value;
				CalculateCostOfDecorations(fancyDecorations);
				CalculateCakeSize();
				this.CakeWriting = cakeWriting;
			}
		}

		private string cakeWriting = "";
		public string CakeWriting
		{
			get => cakeWriting;
			set
			{
				int maxLength = CakeSize == 20 ? 16 : 40;
				if (value.Length > maxLength)
				{
					MessageBox.Show("Za dużo liter dla {0} -centymetrowego tortu", CakeSize.ToString());
					if (maxLength > this.cakeWriting.Length)
					{
						maxLength = this.cakeWriting.Length;
					}

					this.cakeWriting = cakeWriting.Substring(0, maxLength);
				}
				else
				{
					this.cakeWriting = value;
				}
			}
		}

		public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
		{
			this.numberOfPeople = numberOfPeople;
			this.fancyDecorations = fancyDecorations;
			CalculateCakeSize();
			this.CakeWriting = cakeWriting;
			CalculateCostOfDecorations(fancyDecorations);
		}

		public void CalculateCostOfDecorations(bool fancy)
		{
			fancyDecorations = fancy;
			CostOfDecorations = fancy ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
		}

		private void CalculateCakeSize() => CakeSize = NumberOfPeople <= 4 ? 20 : 40;

		public decimal CalculateCost()
		{
			decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
			decimal CakeCost = CakeSize == 20 ? 40M + CakeWriting.Length * 0.25M : 75M + CakeWriting.Length * 0.25M;
			TotalCost += NumberOfPeople > 12 ? 100 : 0;
			return TotalCost + CakeCost;
		}
	}
}