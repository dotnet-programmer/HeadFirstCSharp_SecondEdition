namespace Organizacja_przyjecia
{
	internal class DinnerParty
	{
		private const int CostOfFoodPerPerson = 25;

		private int numberOfPeople;
		public int NumberOfPeople
		{
			get => numberOfPeople;
			set
			{
				numberOfPeople = value;
				CalculateCostOfDecorations(fancyDecorations);
			}
		}

		private bool fancyDecorations;

		public decimal CostOfBeveragesPerPerson;
		public decimal CostOfDecorations = 0;

		public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
		{
			NumberOfPeople = numberOfPeople;
			this.fancyDecorations = fancyDecorations;
			SetHealthyOption(healthyOption);
			CalculateCostOfDecorations(fancyDecorations);
		}

		public void SetHealthyOption(bool healthyOption) => CostOfBeveragesPerPerson = healthyOption ? 5.00M : 20.00M;

		public void CalculateCostOfDecorations(bool fancy)
		{
			fancyDecorations = fancy;
			CostOfDecorations = fancy ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
		}

		public decimal CalculateCost(bool healthyOption)
		{
			decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
			return healthyOption ? totalCost * 0.95M : totalCost;
		}
	}
}