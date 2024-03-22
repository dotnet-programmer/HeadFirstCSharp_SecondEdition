using System;

namespace Delegates
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ConvertsIntToString someMethod = new ConvertsIntToString(HiThere);
			string message = someMethod(5);
			Console.WriteLine(message);
			Console.ReadKey();
		}

		private static string HiThere(int i) 
			=> "Witamy, towarzyszu nr " + (i * 100);
	}
}