using System;
using Upside;

namespace Magnets_Extension_methods
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int i = 1;
			string s = i.ToPrice();
			s.SendIt();

			bool b = true;
			b.Green().SendIt();

			b = false;
			b.Green().SendIt();

			i = 3;
			i.ToPrice().SendIt();

			Console.ReadKey();
		}
	}
}