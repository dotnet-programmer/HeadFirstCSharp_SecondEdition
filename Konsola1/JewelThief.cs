using System;

namespace Konsola1
{
	internal class JewelThief : Locksmith
	{
		private Jewels stolenJewels = null;

		public void ReturnContents(Jewels safeContents, Owner owner)
		{
			stolenJewels = safeContents;
			Console.WriteLine("Kradnę zawartość sejfu! {0}", stolenJewels.Sparkle());
		}
	}
}