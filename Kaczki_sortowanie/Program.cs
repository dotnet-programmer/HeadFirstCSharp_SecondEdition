using System;
using System.Collections.Generic;

namespace Kaczki_sortowanie
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<DuckWithIComparable> Ducks = new List<DuckWithIComparable>()
			{
				new DuckWithIComparable() {Kind = KindOfDuck.Mallard, Size = 17 },
				new DuckWithIComparable() {Kind = KindOfDuck.Muscovy, Size = 18 },
				new DuckWithIComparable() {Kind = KindOfDuck.Decoy, Size = 14 },
				new DuckWithIComparable() {Kind = KindOfDuck.Muscovy, Size = 11 },
				new DuckWithIComparable() {Kind = KindOfDuck.Mallard, Size = 14 },
				new DuckWithIComparable() {Kind = KindOfDuck.Decoy, Size = 13 }
			};

			Console.WriteLine("Lista DuckWithIComparable przed sortowaniem: \r\n");
			ShowDuckWithIComparable(Ducks);

			Ducks.Sort();

			Console.WriteLine("\r\nLista DuckWithIComparable po sortowaniu: \r\n");
			ShowDuckWithIComparable(Ducks);

			Console.ReadKey();

			List<Duck> Ducks2 = new List<Duck>()
			{
				new Duck() {Kind = KindOfDuck.Mallard, Size = 17 },
				new Duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
				new Duck() {Kind = KindOfDuck.Decoy, Size = 14 },
				new Duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
				new Duck() {Kind = KindOfDuck.Mallard, Size = 14 },
				new Duck() {Kind = KindOfDuck.Decoy, Size = 13 }
			};

			DuckComparerBySize sizeComparer = new DuckComparerBySize();

			Console.WriteLine("\r\n\r\nLista Duck z DuckComparerBySize przed sortowaniem: \r\n");
			ShowDuckCompared(Ducks2);

			Ducks2.Sort(sizeComparer);

			Console.WriteLine("\r\nLista Duck z DuckComparerBySize po sortowaniu: \r\n");
			ShowDuckCompared(Ducks2);

			Console.ReadKey();

			DuckComparedByKind sizeComparer2 = new DuckComparedByKind();

			Console.WriteLine("\r\n\r\nLista Duck z DuckComparedByKind przed sortowaniem: \r\n");
			ShowDuckCompared(Ducks2);

			Ducks2.Sort(sizeComparer2);

			Console.WriteLine("\r\nLista Duck z DuckComparedByKind po sortowaniu: \r\n");
			ShowDuckCompared(Ducks2);

			Console.ReadKey();

			DuckComparer comparer = new DuckComparer
			{
				SortBy = SortCriteria.KindThenSize
			};
			Ducks2.Sort(comparer);
			Console.WriteLine("\r\n\r\nLista Duck z DuckComparer : comparer.SortBy = SortCriteria.KindThenSize: \r\n");
			ShowDuckCompared(Ducks2);

			comparer.SortBy = SortCriteria.SizeThenKind;
			Ducks2.Sort(comparer);
			Console.WriteLine("\r\nLista Duck z DuckComparer : comparer.SortBy = SortCriteria.SizeThenKind: \r\n");
			ShowDuckCompared(Ducks2);

			Console.ReadKey();
		}

		public static void ShowDuckWithIComparable(List<DuckWithIComparable> listDuck)
		{
			foreach (var item in listDuck)
			{
				Console.WriteLine(item.DuckInfo);
			}
		}

		public static void ShowDuckCompared(List<Duck> listDuck)
		{
			foreach (var item in listDuck)
			{
				//Console.WriteLine(item.DuckInfo);
				Console.WriteLine(item);
			}
		}
	}
}