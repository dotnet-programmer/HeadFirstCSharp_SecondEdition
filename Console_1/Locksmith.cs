namespace Console_1
{
	internal class Locksmith
	{
		private string _writtenDownCombination = null;

		public void OpenSafe(Safe safe, Owner owner)
		{
			safe.PickLock(this);
			Jewels safeContents = safe.Open(_writtenDownCombination);
			ReturnContents(safeContents, owner);
		}

		public void WriteDownCombination(string combination) 
			=> _writtenDownCombination = combination;

		public void ReturnContents(Jewels safeContents, Owner owner) 
			=> owner.ReceiveContents(safeContents);
	}
}