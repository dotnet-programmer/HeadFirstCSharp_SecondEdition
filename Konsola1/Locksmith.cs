namespace Konsola1
{
	internal class Locksmith
	{
		public void OpenSafe(Safe safe, Owner owner)
		{
			safe.PickLock(this);
			Jewels safeContents = safe.Open(writtenDownCombination);
			ReturnContents(safeContents, owner);
		}

		private string writtenDownCombination = null;

		public void WriteDownCombination(string combination) => writtenDownCombination = combination;

		public void ReturnContents(Jewels safeContents, Owner owner) => owner.RecieveContents(safeContents);
	}
}