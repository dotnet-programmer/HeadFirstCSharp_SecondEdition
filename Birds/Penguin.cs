using System;

namespace Birds
{
	internal class Penguin : Bird
	{
		public override void Fly()
			=> Console.WriteLine("Pingwiny nie latają!");

		public override string ToString()
			=> "Pingwin " + base.Name;
	}
}