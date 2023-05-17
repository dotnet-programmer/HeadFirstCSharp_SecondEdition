using System.IO;

namespace Zagadkowy_basen
{
	public class Pizza
	{
		private readonly StreamWriter writer; // StreamWriter + writer

		public Pizza(StreamWriter writer) // StreamWriter + writer
=> this.writer = writer; // this

		public void Idaho(Pineapple.Fargo f) // Idaho + Pineapple
		{
			writer.WriteLine(f); // WriteLine
			writer.Close(); // Close
		}
	}
}