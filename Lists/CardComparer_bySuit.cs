using System.Collections.Generic;

namespace Lists
{
	internal class CardComparer_bySuit : IComparer<Card>
	{
		public int Compare(Card x, Card y) 
			=> x.Suit > y.Suit ? 1 : x.Suit < y.Suit ? -1 : x.Value > y.Value ? 1 : x.Value < y.Value ? -1 : 0;
	}
}