namespace Konsola1
{
	internal class Safe
	{
		private readonly Jewels contents = new Jewels();
		private readonly string safeCombination = "12345";

		public Jewels Open(string combination) => combination == safeCombination ? contents : null;

		public void PickLock(Locksmith lockpicker) => lockpicker.WriteDownCombination(safeCombination);
	}
}