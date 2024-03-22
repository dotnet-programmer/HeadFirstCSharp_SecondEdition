using System;
using System.Windows.Forms;

namespace Lists
{
	public partial class Form1 : Form
	{
		private Deck _deck1;
		private Deck _deck2;
		private readonly Random _random = new Random();

		public Form1()
		{
			InitializeComponent();

			ResetDeck(1);
			RedrawDeck(1);

			ResetDeck(2);
			RedrawDeck(2);
		}

		public void ResetDeck(int deckNumber)
		{
			if (deckNumber == 1)
			{
				int numberOfCards = _random.Next(1, 11);
				_deck1 = new Deck(new Card[] { });
				for (int i = 0; i < numberOfCards; i++)
				{
					_deck1.Add(new Card((Suits)_random.Next(4), (Values)_random.Next(1, 14)));
				}

				_deck1.Sort();
			}
			else
			{
				_deck2 = new Deck();
			}
		}

		public void RedrawDeck(int deckNumber)
		{
			if (deckNumber == 1)
			{
				RedrawDeckPrivate(ListCard1, LblCards1, _deck1);
			}
			else
			{
				RedrawDeckPrivate(ListCard2, LblCards2, _deck2);
			}
		}

		private void RedrawDeckPrivate(ListBox ListCard, Label label, Deck deck)
		{
			ListCard.Items.Clear();
			foreach (var item in deck.GetCardNames())
			{
				ListCard.Items.Add(item);
			}

			label.Text = "Zestaw 1. (" + deck.Count + " kart)";
		}

		private void BtnMoveToList1_Click(object sender, EventArgs e)
		{
			if (ListCard2.SelectedIndex >= 0)
			{
				if (_deck2.Count > 0)
				{
					_deck1.Add(_deck2.Deal(ListCard2.SelectedIndex));
				}
			}

			RedrawDeck(1);
			RedrawDeck(2);
		}

		private void BtnMoveToList2_Click(object sender, EventArgs e)
		{
			if (ListCard1.SelectedIndex >= 0)
			{
				if (_deck1.Count > 0)
				{
					_deck2.Add(_deck1.Deal(ListCard1.SelectedIndex));
				}
			}

			RedrawDeck(1);
			RedrawDeck(2);
		}

		private void BtnShuffle1_Click(object sender, EventArgs e)
		{
			_deck1.Shuffle();
			RedrawDeck(1);
		}

		private void BtnShuffle2_Click(object sender, EventArgs e)
		{
			_deck2.Shuffle();
			RedrawDeck(2);
		}

		private void BtnResetList1_Click(object sender, EventArgs e)
		{
			ResetDeck(1);
			RedrawDeck(1);
		}

		private void BtnResetList2_Click(object sender, EventArgs e)
		{
			ResetDeck(2);
			RedrawDeck(2);
		}
	}
}