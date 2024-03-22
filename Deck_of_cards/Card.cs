namespace Deck_of_cards
{
	internal class Card
	{
		public Suits Suit;
		public Values Value;

		public Card(Suits Suit, Values Value)
		{
			this.Suit = Suit;
			this.Value = Value;
		}

		public string Name
			=> Value + " of " + Suit;
	}
}