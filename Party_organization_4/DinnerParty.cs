namespace Party_organization_4
{
	internal class DinnerParty : Party
	{
		private const decimal HealthyOptionCost = 5M;
		private const decimal AlcoholOptionCost = 20M;
		private const decimal HealthyOptionDiscount = 0.95M;

		private decimal _costOfBeveragesPerPerson;

		public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base(numberOfPeople, fancyDecorations) 
			=> SetHealthyOption(healthyOption);

		public void SetHealthyOption(bool healthyOption) 
			=> _costOfBeveragesPerPerson = healthyOption ? HealthyOptionCost : AlcoholOptionCost;

		public decimal CalculateCost(bool healthyOption)
		{
			decimal totalCost = base.CalculateCost() + _costOfBeveragesPerPerson * NumberOfPeople;
			return healthyOption ? totalCost * HealthyOptionDiscount : totalCost;
		}
	}
}