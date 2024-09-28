namespace Inheritance
{
	internal class Dog : Animal
	{
		private readonly int _size = 1;

		public int GetSize()
			=> _size;
	}
}