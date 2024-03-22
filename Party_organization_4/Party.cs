namespace Party_organization_4
{
	internal class Party
	{
		private const int CostOfFoodPerPerson = 25;

		private const decimal FantasyDecorationCost = 15M;
		private const decimal FantasyDecorationConst = 50M;
		private const decimal NormalDecorationCost = 7.50M;
		private const decimal NormalDecorationConst = 30M;

		private const int NumberOfPeopleAdditionalCost = 12;
		private const decimal AdditionalCost = 100M;

		private decimal _costOfDecorations = 0;
		private bool _fancyDecorations;
		private int _numberOfPeople;

		public Party(int numberOfPeople, bool fancyDecorations)
		{
			_numberOfPeople = numberOfPeople;
			_fancyDecorations = fancyDecorations;
		}

		public virtual int NumberOfPeople
		{
			get => _numberOfPeople;
			set
			{
				_numberOfPeople = value;
				CalculateCostOfDecorations(_fancyDecorations);
			}
		}

		public void CalculateCostOfDecorations(bool fancy)
		{
			_fancyDecorations = fancy;
			_costOfDecorations = fancy
				? (NumberOfPeople * FantasyDecorationCost) + FantasyDecorationConst
				: (NumberOfPeople * NormalDecorationCost) + NormalDecorationConst;
		}

		public virtual decimal CalculateCost()
		{
			decimal totalCost = _costOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
			if (NumberOfPeople > NumberOfPeopleAdditionalCost)
			{
				totalCost += AdditionalCost;
			}

			return totalCost;
		}
	}
}