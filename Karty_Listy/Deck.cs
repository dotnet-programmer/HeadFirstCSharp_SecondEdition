using System;
using System.Collections.Generic;

namespace Karty_Listy
{
	internal class Deck
	{
		private List<Card> cards;
		private readonly Random random = new Random();

		public Deck()
		{
			cards = new List<Card>();
			for (int suit = 0; suit < 4; suit++)
			{
				for (int value = 1; value < 14; value++)
				{
					cards.Add(new Card((Suits)suit, (Values)value));
				}
			}
		}

		public Deck(IEnumerable<Card> initialCards) => cards = new List<Card>(initialCards);

		public int Count => cards.Count;

		public void Add(Card cartToAdd) => cards.Add(cartToAdd);

		public Card Deal(int index)
		{
			Card cardToDeal = cards[index];
			cards.RemoveAt(index);
			return cardToDeal;
		}

		public void Shuffle()
		{
			List<Card> newCards = new List<Card>();
			while (cards.Count > 0)
			{
				int cardToMove = random.Next(cards.Count);
				newCards.Add(cards[cardToMove]);
				cards.RemoveAt(cardToMove);
			}
			cards = newCards;
		}

		public IEnumerable<string> GetCardNames()
		{
			string[] names = new string[cards.Count];
			for (int i = 0; i < cards.Count; i++)
			{
				names[i] = cards[i].Name;
			}

			return names;
		}

		public void Sort() => cards.Sort(new CardComparer_bySuit());
	}
}