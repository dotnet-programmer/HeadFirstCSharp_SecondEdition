using System.IO;

namespace StreamWriter_magnesy
{
	public class Flobbo
	{
		private string Zap;

		public Flobbo(string Zap) => this.Zap = Zap;

		public StreamWriter Snobbo() => new StreamWriter("ara.txt");

		public bool Blobbo(bool Already, StreamWriter sw)
		{
			if (Already)
			{
				sw.WriteLine(Zap);
				sw.Close();
				return false;
			}
			else
			{
				sw.WriteLine(Zap);
				Zap = "czerwono-pomarańczowa";
				return true;
			}
		}

		public bool Blobbo(StreamWriter sw)
		{
			sw.WriteLine(Zap);
			Zap = "zielono-purpurowa";
			return false;
		}
	}
}