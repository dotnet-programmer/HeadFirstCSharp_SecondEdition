using System.IO;

namespace Riddle_pool_6
{
	public class Party
	{
		private readonly StreamReader reader; // StreamReader

		public Party(StreamReader reader) // StreamReader
=> this.reader = reader; // this

		public void HowMuch(StreamWriter q) // StreamWriter
		{
			q.WriteLine(reader.ReadLine()); // WriteLine + ReadLine
			reader.Close(); // Close
		}
	}
}