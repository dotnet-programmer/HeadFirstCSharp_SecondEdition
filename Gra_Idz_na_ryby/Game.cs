using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gra_Idz_na_ryby
{
	internal class Game
	{
		private readonly List<Player> players;
		private readonly Dictionary<Values, Player> books;
		private readonly Deck stock;
		private readonly TextBox textBoxOnForm;

		public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
		{
			Random random = new Random();
			this.textBoxOnForm = textBoxOnForm;
			players = new List<Player>() { new Player(playerName, random, textBoxOnForm) };
			foreach (string player in opponentNames)
			{
				players.Add(new Player(player, random, textBoxOnForm));
			}

			books = new Dictionary<Values, Player>();
			stock = new Deck();
			Deal();
			players[0].SortHand();
		}

		private void Deal()
		{
			stock.Shuffle();

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					players[j].TakeCard(stock.Deal());
				}
			}

			foreach (var item in players)
			{
				PullOutBooks(item);
			}
		}

		public bool PlayOneRound(int selectedlayerCard)
		{
			Values cardToAskFor = players[0].Peek(selectedlayerCard).Value;
			for (int i = 0; i < players.Count; i++)
			{
				if (i == 0)
				{
					players[0].AskForACard(players, 0, stock, cardToAskFor);
				}
				else
				{
					players[0].AskForACard(players, i, stock);
				}

				if (PullOutBooks(players[i]))
				{
					textBoxOnForm.Text += players[i].Name + " ciągnie karty" + Environment.NewLine;
					int card = 1;
					while (card <= 5 && stock.Count > 0)
					{
						players[i].TakeCard(stock.Deal());
						card++;
					}
				}
				players[0].SortHand();
				if (stock.Count == 0)
				{
					textBoxOnForm.Text = "Na kupce nie ma żadnych kart. Gra skończona!" + Environment.NewLine;
					return true;
				}
			}
			return false;
		}

		public bool PullOutBooks(Player player)
		{
			IEnumerable<Values> booksPulled = player.PullOutBooks();
			foreach (var item in booksPulled)
			{
				books.Add(item, player);
			}

			return player.CardCount == 0;
		}

		public string DescribeBooks()
		{
			string describeBooks = "";

			foreach (var item in books.Keys)
			{
				describeBooks += books[item].Name + " ma grupę " + Card.Plural(item, 0) + Environment.NewLine;
			}

			return describeBooks;
		}

		public string GetWinnerName()
		{
			Dictionary<string, int> winners = new Dictionary<string, int>();
			foreach (var item in books.Keys)
			{
				string name = books[item].Name;
				if (winners.ContainsKey(name))
				{
					winners[name]++;
				}
				else
				{
					winners.Add(name, 1);
				}
			}
			int mostBooks = 0;
			foreach (var item in winners.Keys)
			{
				if (winners[item] > mostBooks)
				{
					mostBooks = winners[item];
				}
			}

			bool tie = false;
			string winnerList = "";
			foreach (var item in winners.Keys)
			{
				if (winners[item] == mostBooks)
				{
					if (!string.IsNullOrEmpty(winnerList))
					{
						winnerList += " i ";
						tie = true;
					}
					winnerList += item;
				}
			}

			winnerList += ": " + mostBooks + " grupy ";
			return tie ? "Remis pomiędzy " + winnerList : winnerList;
		}

		public IEnumerable<string> GetPlayerCardNames() => players[0].GetCardNames();

		public string DescribePlayerHands()
		{
			string description = "";
			for (int i = 0; i < players.Count; i++)
			{
				description += players[i].Name + " ma " + players[i].CardCount;
				if (players[i].CardCount == 1)
				{
					description += " kartę.\r\n";
				}
				else if (players[i].CardCount == 2 || players[i].CardCount == 3 || players[i].CardCount == 4)
				{
					description += " karty.\r\n";
				}
				else
				{
					description += " kart.\r\n";
				}
			}
			description += "Na kupce pozostało kart: " + stock.Count + Environment.NewLine;
			return description;
		}
	}
}