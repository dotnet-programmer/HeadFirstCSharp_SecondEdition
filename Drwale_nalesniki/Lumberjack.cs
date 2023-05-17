using System.Collections.Generic;

namespace Drwale_nalesniki
{
	internal class Lumberjack
	{
		public string Name { get; }
		private readonly Stack<Flapjack> meal;

		public Lumberjack(string name)
		{
			Name = name;
			meal = new Stack<Flapjack>();
		}

		public int FlapjackCount => meal.Count;

		public void TakeFlapjacks(Flapjack food, int howMany)
		{
			for (int i = 0; i < howMany; i++)
			{
				meal.Push(food);
			}
		}

		public void EatFlapjacks()
		{
			string text = Name + " je naleśniki\r\n";
			while (meal.Count > 0)
			{
				text += Name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśniki\r\n";
			}

			System.Windows.Forms.MessageBox.Show(text);

			//Console.WriteLine(Name + " je naleśniki");
			//while (meal.Count > 0)
			//	Console.WriteLine(Name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśniki");
		}
	}

	public enum Flapjack
	{ Chrupkiego, Wilgotnego, Rumianego, Bananowego }
}