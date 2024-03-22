using System;

namespace Console_1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Owner owner = new Owner();
			Safe safe = new Safe();
			JewelThief jewelThief = new JewelThief();
			jewelThief.OpenSafe(safe, owner);
			Console.ReadKey();
		}
	}
}