namespace Console_1
{
	internal class Safe
	{
		private readonly Jewels _contents = new Jewels();
		private readonly string _safeCombination = "12345";

		public Jewels Open(string combination) 
			=> combination == _safeCombination ? _contents : null;

		public void PickLock(Locksmith lockpicker) 
			=> lockpicker.WriteDownCombination(_safeCombination);
	}
}