namespace Organizacja_przyjecia_4
{
	internal class Party
	{
		private const int costOfFoodPerPerson = 25;

		private const decimal fantasyDecorationCost = 15M;
		private const decimal fantasyDecorationConst = 50M;
		private const decimal normalDecorationCost = 7.50M;
		private const decimal normalDecorationConst = 30M;

		private const int numberOfPeopleAdditionalCost = 12;
		private const decimal additionalCost = 100M;

		private decimal CostOfDecorations = 0;
		private bool fancyDecorations;

		public Party(int numberOfPeople, bool fancyDecorations)
		{
			this.numberOfPeople = numberOfPeople;
			this.fancyDecorations = fancyDecorations;
		}

		private int numberOfPeople;
		public virtual int NumberOfPeople
		{
			get => numberOfPeople;
			set
			{
				numberOfPeople = value;
				CalculateCostOfDecorations(fancyDecorations);
			}
		}

		public void CalculateCostOfDecorations(bool fancy)
		{
			fancyDecorations = fancy;
			CostOfDecorations = fancy
				? (NumberOfPeople * fantasyDecorationCost) + fantasyDecorationConst
				: (NumberOfPeople * normalDecorationCost) + normalDecorationConst;
		}

		public virtual decimal CalculateCost()
		{
			decimal totalCost = CostOfDecorations + (costOfFoodPerPerson * NumberOfPeople);
			if (NumberOfPeople > numberOfPeopleAdditionalCost)
			{
				totalCost += additionalCost;
			}

			return totalCost;
		}
	}
}