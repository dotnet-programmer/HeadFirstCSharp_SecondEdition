using System;

namespace Ptaki
{
	internal class Penguin : Bird
	{
		public override void Fly() => Console.WriteLine("Pingwiny nie latajo!");

		public override string ToString() => "Pingwin " + base.Name;
	}
}