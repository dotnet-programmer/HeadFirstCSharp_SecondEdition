using System;

namespace Console_1
{
	internal class Owner
	{
		private Jewels _returnedContents;

		public void ReceiveContents(Jewels safeContents)
		{
			_returnedContents = safeContents;
			Console.WriteLine("Dziękujemy za zwrócenie klejnotów! {0}", safeContents.Sparkle());
		}
	}
}