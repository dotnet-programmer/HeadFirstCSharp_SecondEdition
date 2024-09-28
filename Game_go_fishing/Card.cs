namespace Game_go_fishing
{
	internal class Card
	{
		public Suits Suit;
		public Values Value;

		private static readonly string[] _names0 = new string[]
			{ "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli" };

		private static readonly string[] _names1 = new string[]
			{ "", "asa", "dwójkę", "trójkę", "czwórkę", "piatkę", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla" };

		private static readonly string[] _names2AndMore = new string[]
			{ "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle" };

		private static readonly string[] _suits = new string[]
			{ "pik", "trefl", "karo", "kier" };

		private static readonly string[] _names = new string[]
			{ "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król" };

		public Card(Suits Suit, Values Value)
		{
			this.Suit = Suit;
			this.Value = Value;
		}

		public override string ToString()
			=> Name;

		public static string Plural(Values value, int count)
			=> count == 0 ? _names0[(int)value] : count == 1 ? _names1[(int)value] : _names2AndMore[(int)value];

		//public string Name { get => Value + " of " + Suit; }
		public string Name
			=> _names[(int)Value] + " " + _suits[(int)Suit];
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