using System.Windows.Forms;

namespace Party_organization_2
{
	internal class BirthdayParty
	{
		public const int CostOfFoodPerPerson = 25;
		public decimal CostOfDecorations = 0;
		private bool _fancyDecorations;
		public int CakeSize;
		private string _cakeWriting = "";
		private int _numberOfPeople;

		public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
		{
			_numberOfPeople = numberOfPeople;
			_fancyDecorations = fancyDecorations;
			CalculateCakeSize();
			CakeWriting = cakeWriting;
			CalculateCostOfDecorations(fancyDecorations);
		}

		public int NumberOfPeople
		{
			get => _numberOfPeople;
			set
			{
				_numberOfPeople = value;
				CalculateCostOfDecorations(_fancyDecorations);
				CalculateCakeSize();
				CakeWriting = _cakeWriting;
			}
		}

		public string CakeWriting
		{
			get => _cakeWriting;
			set
			{
				int maxLength = CakeSize == 20 ? 16 : 40;
				if (value.Length > maxLength)
				{
					MessageBox.Show("Za dużo liter dla {0} -centymetrowego tortu", CakeSize.ToString());
					if (maxLength > _cakeWriting.Length)
					{
						maxLength = _cakeWriting.Length;
					}

					_cakeWriting = _cakeWriting.Substring(0, maxLength);
				}
				else
				{
					_cakeWriting = value;
				}
			}
		}

		public void CalculateCostOfDecorations(bool fancy)
		{
			_fancyDecorations = fancy;
			CostOfDecorations = fancy ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
		}

		public decimal CalculateCost()
		{
			decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
			decimal CakeCost = CakeSize == 20 ? 40M + CakeWriting.Length * 0.25M : 75M + CakeWriting.Length * 0.25M;
			TotalCost += NumberOfPeople > 12 ? 100 : 0;
			return TotalCost + CakeCost;
		}

		private void CalculateCakeSize()
			=> CakeSize = NumberOfPeople <= 4 ? 20 : 40;
	}
}