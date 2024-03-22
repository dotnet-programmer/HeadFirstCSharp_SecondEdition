namespace Party_organization
{
	internal class DinnerParty
	{
		private const int CostOfFoodPerPerson = 25;

		private int _numberOfPeople;
		private bool _fancyDecorations;
		
		public decimal CostOfBeveragesPerPerson;
		public decimal CostOfDecorations = 0;

		public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
		{
			NumberOfPeople = numberOfPeople;
			_fancyDecorations = fancyDecorations;
			SetHealthyOption(healthyOption);
			CalculateCostOfDecorations(fancyDecorations);
		}

		public int NumberOfPeople
		{
			get => _numberOfPeople;
			set
			{
				_numberOfPeople = value;
				CalculateCostOfDecorations(_fancyDecorations);
			}
		}

		public void SetHealthyOption(bool healthyOption) 
			=> CostOfBeveragesPerPerson = healthyOption ? 5.00M : 20.00M;

		public void CalculateCostOfDecorations(bool fancy)
		{
			_fancyDecorations = fancy;
			CostOfDecorations = fancy ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
		}

		public decimal CalculateCost(bool healthyOption)
		{
			decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
			return healthyOption ? totalCost * 0.95M : totalCost;
		}
	}
}