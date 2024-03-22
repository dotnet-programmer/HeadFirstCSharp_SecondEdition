using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_go_fishing
{
	internal class Game
	{
		private readonly List<Player> _players;
		private readonly Dictionary<Values, Player> _books;
		private readonly Deck _stock;
		private readonly TextBox _textBoxOnForm;

		public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
		{
			Random random = new Random();
			_textBoxOnForm = textBoxOnForm;
			_players = new List<Player>() { new Player(playerName, random, textBoxOnForm) };
			foreach (string player in opponentNames)
			{
				_players.Add(new Player(player, random, textBoxOnForm));
			}

			_books = new Dictionary<Values, Player>();
			_stock = new Deck();
			Deal();
			_players[0].SortHand();
		}

		private void Deal()
		{
			_stock.Shuffle();

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					_players[j].TakeCard(_stock.Deal());
				}
			}

			foreach (var item in _players)
			{
				PullOutBooks(item);
			}
		}

		public bool PlayOneRound(int selectedlayerCard)
		{
			Values cardToAskFor = _players[0].Peek(selectedlayerCard).Value;
			for (int i = 0; i < _players.Count; i++)
			{
				if (i == 0)
				{
					_players[0].AskForACard(_players, 0, _stock, cardToAskFor);
				}
				else
				{
					_players[0].AskForACard(_players, i, _stock);
				}

				if (PullOutBooks(_players[i]))
				{
					_textBoxOnForm.Text += _players[i].Name + " ciągnie karty" + Environment.NewLine;
					int card = 1;
					while (card <= 5 && _stock.Count > 0)
					{
						_players[i].TakeCard(_stock.Deal());
						card++;
					}
				}
				_players[0].SortHand();
				if (_stock.Count == 0)
				{
					_textBoxOnForm.Text = "Na kupce nie ma żadnych kart. Gra skończona!" + Environment.NewLine;
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
				_books.Add(item, player);
			}

			return player.CardCount == 0;
		}

		public string DescribeBooks()
		{
			string describeBooks = "";

			foreach (var item in _books.Keys)
			{
				describeBooks += _books[item].Name + " ma grupę " + Card.Plural(item, 0) + Environment.NewLine;
			}

			return describeBooks;
		}

		public string GetWinnerName()
		{
			Dictionary<string, int> winners = new Dictionary<string, int>();
			foreach (var item in _books.Keys)
			{
				string name = _books[item].Name;
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

		public IEnumerable<string> GetPlayerCardNames()
			=> _players[0].GetCardNames();

		public string DescribePlayerHands()
		{
			string description = "";
			for (int i = 0; i < _players.Count; i++)
			{
				description += _players[i].Name + " ma " + _players[i].CardCount;
				if (_players[i].CardCount == 1)
				{
					description += " kartę.\r\n";
				}
				else if (_players[i].CardCount == 2 || _players[i].CardCount == 3 || _players[i].CardCount == 4)
				{
					description += " karty.\r\n";
				}
				else
				{
					description += " kart.\r\n";
				}
			}
			description += "Na kupce pozostało kart: " + _stock.Count + Environment.NewLine;
			return description;
		}
	}
}