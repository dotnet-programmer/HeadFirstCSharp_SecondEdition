using System.IO;

namespace Riddle_pool_6
{
	public class Pineapple
	{
		private const string d = "dostawa.txt"; // string

		public enum Fargo
		{ North, South, East, West, Flamingo } // enum Fargo

		public static void Main()
		{
			StreamWriter o = new StreamWriter("zamownienie.txt"); // StreamWriter + StreamWriter
			Pizza pz = new Pizza(new StreamWriter(d, true)); // StreamWriter
			pz.Idaho(Fargo.Flamingo); // Idaho
			for (int w = 3; w >= 0; w--) // int
			{
				Pizza i = new Pizza(new StreamWriter(d, false)); // StreamWriter
				i.Idaho((Fargo)w);
				Party p = new Party(new StreamReader(d)); // StreamReader
				p.HowMuch(o); // HowMuch
			}
			o.WriteLine("To wszystko kochani!"); // WriteLine
			o.Close(); // Close
		}
	}
}