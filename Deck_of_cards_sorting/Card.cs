namespace Deck_of_cards_sorting
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


		public override string ToString() 
			=> Name;
	}
}