using System;

namespace Birds
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Bird bird = new Bird();
			Penguin penguin = new Penguin();
			Duck duck = new Duck();

			bird.Fly();
			Console.WriteLine($"name = {bird.Name}");
			Console.WriteLine(bird);
			Console.WriteLine();

			penguin.Fly();
			Console.WriteLine($"name = {penguin.Name}");
			Console.WriteLine(penguin);
			Console.WriteLine();

			duck.Fly();
			Console.WriteLine($"name = {duck.Name}");
			Console.WriteLine(duck);
		}
	}
}