using System;
using System.Collections.Generic;

namespace Game_go_fishing
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
			=> _cards.Sort(new CardComparer_byValue());

		public Card Peek(int cardNumber)
			=> _cards[cardNumber];

		public Card Deal()
			=> Deal(0);

		public bool ContainsValue(Values value)
		{
			foreach (var item in _cards)
			{
				if (item.Value == value)
				{
					return true;
				}
			}

			return false;
		}

		public Deck PullOutValues(Values value)
		{
			Deck deckToReturn = new Deck(new Card[] { });
			for (int i = _cards.Count - 1; i >= 0; i--)
			{
				if (_cards[i].Value == value)
				{
					deckToReturn.Add(Deal(i));
				}
			}

			return deckToReturn;
		}

		public bool HasBook(Values value)
		{
			int NumberOfCards = 0;
			foreach (var item in _cards)
			{
				if (item.Value == value)
				{
					NumberOfCards++;
				}
			}

			return NumberOfCards == 4;
		}

		public void SortByValue()
			=> _cards.Sort(new CardComparer_byValue());
	}
}