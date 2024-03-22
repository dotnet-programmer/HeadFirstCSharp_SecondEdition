using System.Windows.Forms;

namespace Party_organization_4
{
	internal class BirthdayParty : Party
	{
		private const int SmallCakeSize = 20;
		private const decimal SmallCakeCost = 40M;
		private const int LargeCakeSize = 40;
		private const decimal LargeCakeCost = 75M;
		private const decimal LetterCost = 0.25M;
		private const int SmallCakeMaxLetters = 16;
		private const int LargeCakeMaxLetters = 40;

		private string _cakeWriting = "";
		private int _cakeSize;
		private int _cakeLetters;

		public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base(numberOfPeople, fancyDecorations)
		{
			CalculateCakeSize();
			CakeWriting = cakeWriting;
		}

		public override int NumberOfPeople
		{
			get => base.NumberOfPeople;
			set
			{
				base.NumberOfPeople = value;
				CalculateCakeSize();
				CakeWriting = _cakeWriting;
			}
		}

		public string CakeWriting
		{
			get => _cakeWriting;
			set
			{
				if (value.Length > _cakeLetters)
				{
					MessageBox.Show("Za dużo liter dla {0} -centymetrowego tortu", _cakeSize.ToString());
					if (_cakeLetters > _cakeWriting.Length)
					{
						_cakeLetters = _cakeWriting.Length;
					}

					_cakeWriting = _cakeWriting.Substring(0, _cakeLetters);
				}
				else
				{
					_cakeWriting = value;
				}
			}
		}

		public override decimal CalculateCost()
		{
			decimal totalCost = base.CalculateCost();
			totalCost += (_cakeSize == SmallCakeSize) ? SmallCakeCost : LargeCakeCost;
			totalCost += CakeWriting.Length * LetterCost;
			return totalCost;
		}

		private void CalculateCakeSize()
		{
			_cakeSize = NumberOfPeople <= 4 ? SmallCakeSize : LargeCakeSize;
			_cakeLetters = NumberOfPeople <= 4 ? SmallCakeMaxLetters : LargeCakeMaxLetters;
		}
	}
}