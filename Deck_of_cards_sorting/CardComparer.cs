using System.Collections.Generic;

namespace Deck_of_cards_sorting
{
	internal class CardComparer : IComparer<Card>
	{
		public int Compare(Card x, Card y) 
			=> x.Value > y.Value ? 1 : x.Value < y.Value ? -1 : x.Suit > y.Suit ? 1 : x.Suit < y.Suit ? -1 : 0;
	}
}