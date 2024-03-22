using System;
using System.Collections.Generic;

namespace Deck_of_cards_sorting
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Random random = new Random();
			List<Card> Cards = new List<Card>();

			for (int i = 0; i < 5; i++)
			{
				Cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
			}

			Console.WriteLine("Pięć losowych kart:");
			ShowCards(Cards);

			Cards.Sort(new CardComparer());

			Console.WriteLine("\r\nPięć posortowanych kart:");
			ShowCards(Cards);

			Console.ReadKey();
		}

		public static void ShowCards(List<Card> cards)
		{
			foreach (var item in cards)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}