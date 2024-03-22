using System;

namespace Upside
{
	public static class Margin
	{
		public static void SendIt(this string s) => Console.Write(s);

		public static string ToPrice(this int n) => n == 1 ? "a buck " : " more bucks";

		public static string Green(this bool b) => b == true ? "be" : "gets";
	}
}