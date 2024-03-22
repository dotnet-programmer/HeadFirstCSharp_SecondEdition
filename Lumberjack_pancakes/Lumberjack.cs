using System.Collections.Generic;

namespace Lumberjack_pancakes
{
	internal class Lumberjack
	{
		public string Name { get; }
		private readonly Stack<Flapjack> _meal;

		public Lumberjack(string name)
		{
			Name = name;
			_meal = new Stack<Flapjack>();
		}

		public int FlapjackCount 
			=> _meal.Count;

		public void TakeFlapjacks(Flapjack food, int howMany)
		{
			for (int i = 0; i < howMany; i++)
			{
				_meal.Push(food);
			}
		}

		public void EatFlapjacks()
		{
			string text = Name + " je naleśniki\r\n";
			while (_meal.Count > 0)
			{
				text += Name + " zjadł " + _meal.Pop().ToString().ToLower() + " naleśniki\r\n";
			}

			System.Windows.Forms.MessageBox.Show(text);

			//Console.WriteLine(Name + " je naleśniki");
			//while (meal.Count > 0)
			//	Console.WriteLine(Name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśniki");
		}
	}

	public enum Flapjack
	{ 
		Chrupkiego, Wilgotnego, Rumianego, Bananowego 
	}
}