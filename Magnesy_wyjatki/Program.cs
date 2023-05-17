using System;

namespace Magnesy_wyjatki
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("when it ");
			ExTestDrive.Zero("yes");
			Console.Write(" it ");
			ExTestDrive.Zero("no");
			Console.WriteLine(".");
			Console.ReadLine();
		}

		private class MyException : Exception
		{ }

		public class ExTestDrive
		{
			public static void Zero(string test)
			{
				try
				{
					Console.Write("t");
					DoRisky(test);
					Console.Write("o");
				}
				catch (MyException)
				{
					Console.Write("a");
				}
				finally
				{
					Console.Write("w");
				}
				Console.Write("s");
			}

			private static void DoRisky(string t)
			{
				Console.Write("h");
				if (t == "yes")
				{
					throw new MyException();
				}
				Console.Write("r");
			}
		}
	}
}