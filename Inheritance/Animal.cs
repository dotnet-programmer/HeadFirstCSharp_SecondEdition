namespace Inheritance
{
	internal class Animal
	{
		public int age;
		private readonly int _hunger = 13;

		public int GetAge()
			=> age;

		public int GetHunger()
			=> _hunger;
	}
}