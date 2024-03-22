using System;

namespace Console_1
{
	internal class JewelThief : Locksmith
	{
		private Jewels _stolenJewels = null;

		public void ReturnContents(Jewels safeContents, Owner owner)
		{
			_stolenJewels = safeContents;
			Console.WriteLine("Kradnę zawartość sejfu! {0}", _stolenJewels.Sparkle());
		}
	}
}