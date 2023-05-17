namespace Gra_Idz_na_ryby
{
	internal class Card
	{
		public Suits Suit;
		public Values Value;
		//public string Name { get => Value + " of " + Suit; }

		public Card(Suits Suit, Values Value)
		{
			this.Suit = Suit;
			this.Value = Value;
		}

		public override string ToString() => Name;

		private static readonly string[] names0 = new string[]
		{ "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli" };

		private static readonly string[] names1 = new string[]
		{ "", "asa", "dwójkę", "trójkę", "czwórkę", "piatkę", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla" };

		private static readonly string[] names2AndMore = new string[]
		{ "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle" };

		public static string Plural(Values value, int count) => count == 0 ? names0[(int)value] : count == 1 ? names1[(int)value] : names2AndMore[(int)value];

		private static readonly string[] suits = new string[] { "pik", "trefl", "karo", "kier" };

		private static readonly string[] names = new string[]
		{ "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król" };

		public string Name => names[(int)Value] + " " + suits[(int)Suit];
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