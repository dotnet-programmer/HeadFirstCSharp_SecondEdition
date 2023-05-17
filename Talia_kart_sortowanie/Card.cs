namespace Talia_kart_sortowanie
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
}