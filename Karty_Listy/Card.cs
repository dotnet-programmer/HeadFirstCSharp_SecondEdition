namespace Karty_Listy
{
	internal class Card
	{
		public Suits Suit;
		public Values Value;
		public string Name => Value + " of " + Suit;

		public Card(Suits Suit, Values Value)
		{
			this.Suit = Suit;
			this.Value = Value;
		}

		public override string ToString() => Name;
	}

	internal enum Suits
	{
		Spades,
		Clubs,
		Diamonds,
		Hearts
	}

	internal enum Values
	{
		Ace = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13
	}
}