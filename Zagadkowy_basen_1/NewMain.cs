namespace Zagadkowy_basen_1
{
	internal class NewMain
	{
		private static void Main()
		{
			int x = 0;
			string Poem = "";

			while (x < 4)
			{
				Poem += "a";
				if (x < 1)
				{
					Poem += " ";
				}
				Poem += "n";
				if (x > 1)
				{
					Poem += " oyster";
					x += 2;
				}
				if (x == 1)
				{
					Poem += "noys ";
				}
				if (x < 1)
				{
					Poem += "oise ";
				}
				x++;
			}
			System.Windows.Forms.MessageBox.Show(Poem);
		}
	}
}