using System;
using System.Windows.Forms;

namespace Karty_Listy
{
	public partial class Form1 : Form
	{
		private Deck deck1;
		private Deck deck2;
		private readonly Random random = new Random();

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
				int numberOfCards = random.Next(1, 11);
				deck1 = new Deck(new Card[] { });
				for (int i = 0; i < numberOfCards; i++)
				{
					deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
				}

				deck1.Sort();
			}
			else
			{
				deck2 = new Deck();
			}
		}

		public void RedrawDeck(int deckNumber)
		{
			if (deckNumber == 1)
			{
				RedrawDeckPrivate(ListCard1, LblCards1, deck1);
			}
			else
			{
				RedrawDeckPrivate(ListCard2, LblCards2, deck2);
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
				if (deck2.Count > 0)
				{
					deck1.Add(deck2.Deal(ListCard2.SelectedIndex));
				}
			}

			RedrawDeck(1);
			RedrawDeck(2);
		}

		private void BtnMoveToList2_Click(object sender, EventArgs e)
		{
			if (ListCard1.SelectedIndex >= 0)
			{
				if (deck1.Count > 0)
				{
					deck2.Add(deck1.Deal(ListCard1.SelectedIndex));
				}
			}

			RedrawDeck(1);
			RedrawDeck(2);
		}

		private void BtnShuffle1_Click(object sender, EventArgs e)
		{
			deck1.Shuffle();
			RedrawDeck(1);
		}

		private void BtnShuffle2_Click(object sender, EventArgs e)
		{
			deck2.Shuffle();
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