namespace Racing
{
	internal class Bet
	{
		public int Amount { get; set; }
		public int Dog { get; set; }
		public Guy Bettor { get; set; }

		public string GetDescription()
			=> Amount > 0
			? Bettor.Name + " obstawił " + Amount + " zł na psa numer " + Dog
			: Bettor.Name + " nie zawarł zakładu";

		public int PayOut(int Winner)
			=> Dog == Winner ? Amount : -Amount;
	}
}