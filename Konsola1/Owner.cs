using System;

namespace Konsola1
{
	internal class Owner
	{
		private Jewels returnetContents;

		public void RecieveContents(Jewels safeContents)
		{
			returnetContents = safeContents;
			Console.WriteLine("Dziękujemy za zwrócenie klejnotów! {0}", safeContents.Sparkle());
		}
	}
}