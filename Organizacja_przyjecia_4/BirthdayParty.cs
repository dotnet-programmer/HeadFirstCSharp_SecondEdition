using System.Windows.Forms;

namespace Organizacja_przyjecia_4
{
	internal class BirthdayParty : Party
	{
		private const int smallCakeSize = 20;
		private const decimal smallCakeCost = 40M;
		private const int largeCakeSize = 40;
		private const decimal largeCakeCost = 75M;
		private const decimal letterCost = 0.25M;
		private const int smallCakeMaxLetters = 16;
		private const int largeCakeMaxLetters = 40;

		private int cakeSize;
		private int cakeLetters;

		public override int NumberOfPeople
		{
			get => base.NumberOfPeople;
			set
			{
				base.NumberOfPeople = value;
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
				if (value.Length > cakeLetters)
				{
					MessageBox.Show("Za dużo liter dla {0} -centymetrowego tortu", cakeSize.ToString());
					if (cakeLetters > this.cakeWriting.Length)
					{
						cakeLetters = this.cakeWriting.Length;
					}

					this.cakeWriting = cakeWriting.Substring(0, cakeLetters);
				}
				else
				{
					this.cakeWriting = value;
				}
			}
		}

		public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base(numberOfPeople, fancyDecorations)
		{
			CalculateCakeSize();
			this.CakeWriting = cakeWriting;
		}

		private void CalculateCakeSize()
		{
			cakeSize = NumberOfPeople <= 4 ? smallCakeSize : largeCakeSize;
			cakeLetters = NumberOfPeople <= 4 ? smallCakeMaxLetters : largeCakeMaxLetters;
		}

		public override decimal CalculateCost()
		{
			decimal totalCost = base.CalculateCost();
			totalCost += (cakeSize == smallCakeSize) ? smallCakeCost : largeCakeCost;
			totalCost += CakeWriting.Length * letterCost;
			return totalCost;
		}
	}
}