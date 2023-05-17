namespace Organizacja_przyjecia_4
{
	internal class DinnerParty : Party
	{
		private const decimal healthyOptionCost = 5M;
		private const decimal alcoholOptionCost = 20M;
		private const decimal healthyOptionDiscount = 0.95M;

		private decimal CostOfBeveragesPerPerson;

		public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base(numberOfPeople, fancyDecorations) => SetHealthyOption(healthyOption);

		public void SetHealthyOption(bool healthyOption) => CostOfBeveragesPerPerson = healthyOption ? healthyOptionCost : alcoholOptionCost;

		public decimal CalculateCost(bool healthyOption)
		{
			decimal totalCost = base.CalculateCost() + CostOfBeveragesPerPerson * NumberOfPeople;

			return healthyOption ? totalCost * healthyOptionDiscount : totalCost;
		}
	}
}