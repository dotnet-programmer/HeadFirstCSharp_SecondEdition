using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_go_fishing
{
	internal class Player
	{
		private readonly string _name;
		private readonly Random _random;
		private readonly Deck _cards;
		private readonly TextBox _textBoxOnForm;

		public Player(string name, Random random, TextBox textBoxOnForm)
		{
			_name = name;
			_textBoxOnForm = textBoxOnForm;
			_random = random;
			_cards = new Deck(new Card[] { });
			_textBoxOnForm.Text += this._name + " dołączył do gry\r\n";
		}

		public string Name
			=> _name;

		public int CardCount
			=> _cards.Count;

		public IEnumerable<Values> PullOutBooks()
		{
			List<Values> books = new List<Values>();
			for (int i = 1; i < 14; i++)
			{
				Values value = (Values)i;
				int howMany = 0;
				for (int card = 0; card < _cards.Count; card++)
				{
					if (_cards.Peek(card).Value == value)
					{
						howMany++;
					}
				}

				if (howMany == 4)
				{
					books.Add(value);
					for (int card = _cards.Count - 1; card >= 0; card--)
					{
						_cards.Deal(card);
					}
				}
			}
			return books;
		}

		public Values GetRandomValue()
		{
			Card randomCard = _cards.Peek(_random.Next(_cards.Count));
			return randomCard.Value;
		}

		public Deck DoYouHaheAny(Values value)
		{
			Deck cardsIHave = _cards.PullOutValues(value);
			_textBoxOnForm.Text += Name + " ma " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
			return cardsIHave;
		}

		public void AskForACard(List<Player> players, int myIndex, Deck stock)
		{
			Values randomValue = GetRandomValue();
			AskForACard(players, myIndex, stock, randomValue);
		}

		public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
		{
			_textBoxOnForm.Text += Name + " pyta, czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
			int totalCardsGiven = 0;
			for (int i = 0; i < players.Count; i++)
			{
				if (i != myIndex)
				{
					Player player = players[i];
					Deck CardsGiven = player.DoYouHaheAny(value);
					totalCardsGiven += CardsGiven.Count;
					while (CardsGiven.Count > 0)
					{
						_cards.Add(CardsGiven.Deal());
					}
				}
			}

			if (totalCardsGiven == 0)
			{
				_textBoxOnForm.Text += Name + " pobrał kartę z kupki." + Environment.NewLine;
				_cards.Add(stock.Deal());
			}
		}

		public void TakeCard(Card card)
			=> _cards.Add(card);

		public IEnumerable<string> GetCardNames()
			=> _cards.GetCardNames();

		public Card Peek(int cardNumber)
			=> _cards.Peek(cardNumber);

		public void SortHand()
			=> _cards.SortByValue();
	}
}