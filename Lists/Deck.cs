using System;
using System.Collections.Generic;

namespace Lists
{
	internal class Deck
	{
		private List<Card> _cards;
		private readonly Random _random = new Random();

		public Deck()
		{
			_cards = new List<Card>();
			for (int suit = 0; suit < 4; suit++)
			{
				for (int value = 1; value < 14; value++)
				{
					_cards.Add(new Card((Suits)suit, (Values)value));
				}
			}
		}

		public Deck(IEnumerable<Card> initialCards) 
			=> _cards = new List<Card>(initialCards);

		public int Count 
			=> _cards.Count;

		public void Add(Card cartToAdd) 
			=> _cards.Add(cartToAdd);

		public Card Deal(int index)
		{
			Card cardToDeal = _cards[index];
			_cards.RemoveAt(index);
			return cardToDeal;
		}

		public void Shuffle()
		{
			List<Card> newCards = new List<Card>();
			while (_cards.Count > 0)
			{
				int cardToMove = _random.Next(_cards.Count);
				newCards.Add(_cards[cardToMove]);
				_cards.RemoveAt(cardToMove);
			}
			_cards = newCards;
		}

		public IEnumerable<string> GetCardNames()
		{
			string[] names = new string[_cards.Count];
			for (int i = 0; i < _cards.Count; i++)
			{
				names[i] = _cards[i].Name;
			}

			return names;
		}

		public void Sort() 
			=> _cards.Sort(new CardComparer_bySuit());
	}
}