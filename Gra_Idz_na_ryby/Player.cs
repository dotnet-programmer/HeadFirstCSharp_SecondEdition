using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gra_Idz_na_ryby
{
	internal class Player
	{
		private readonly string name;
		public string Name => name;
		private readonly Random random;
		private readonly Deck cards;
		private readonly TextBox textBoxOnForm;

		public Player(string name, Random random, TextBox textBoxOnForm)
		{
			this.name = name;
			this.random = random;
			this.textBoxOnForm = textBoxOnForm;
			this.cards = new Deck(new Card[] { });
			this.textBoxOnForm.Text += this.name + " dołączył do gry\r\n";
		}

		public IEnumerable<Values> PullOutBooks()
		{
			List<Values> books = new List<Values>();
			for (int i = 1; i < 14; i++)
			{
				Values value = (Values)i;
				int howMany = 0;
				for (int card = 0; card < cards.Count; card++)
				{
					if (cards.Peek(card).Value == value)
					{
						howMany++;
					}
				}

				if (howMany == 4)
				{
					books.Add(value);
					for (int card = cards.Count - 1; card >= 0; card--)
					{
						cards.Deal(card);
					}
				}
			}
			return books;
		}

		public Values GetRandomValue()
		{
			Card randomCard = cards.Peek(random.Next(cards.Count));
			return randomCard.Value;
		}

		public Deck DoYouHaheAny(Values value)
		{
			Deck cardsIHave = cards.PullOutValues(value);
			textBoxOnForm.Text += Name + " ma " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
			return cardsIHave;
		}

		public void AskForACard(List<Player> players, int myIndex, Deck stock)
		{
			Values randomValue = GetRandomValue();
			AskForACard(players, myIndex, stock, randomValue);
		}

		public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
		{
			textBoxOnForm.Text += Name + " pyta, czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
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
						cards.Add(CardsGiven.Deal());
					}
				}
			}

			if (totalCardsGiven == 0)
			{
				textBoxOnForm.Text += Name + " pobrał kartę z kupki." + Environment.NewLine;
				cards.Add(stock.Deal());
			}
		}

		public int CardCount => cards.Count;

		public void TakeCard(Card card) => cards.Add(card);

		public IEnumerable<string> GetCardNames() => cards.GetCardNames();

		public Card Peek(int cardNumber) => cards.Peek(cardNumber);

		public void SortHand() => cards.SortByValue();
	}
}