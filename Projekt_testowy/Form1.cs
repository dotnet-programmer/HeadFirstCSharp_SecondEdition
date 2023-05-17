using System;
using System.Windows.Forms;

namespace Projekt_testowy
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void Btn1_Click(object sender, EventArgs e)
		{
			int number = 15;
			number = number + 10;
			number = 36 * 15;
			number = 12 - (42 / 7);
			number += 10;
			number *= 3;
			number = 71 / 3;

			int count = 0;
			count++;
			count--;
			string result = "cześć";
			result += " i znowu " + result;
			MessageBox.Show(result);
			result = "wartość wynosi " + count;
			result = "";
		}

		/// <summary>
		/// Przycisk 1
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			string name = "Quentin";
			int x = 3;
			x *= 17;
			double d = Math.PI / 2;
			MessageBox.Show("Nazwa to " + name + "\nx jest równe " + x + "\nd jest równe " + d);
		}

		/// <summary>
		/// Przycisk 2
		/// </summary>
		private void button2_Click(object sender, EventArgs e)
		{
			int x = 5;
			if (x == 10)
			{
				MessageBox.Show("x musi być równe 10");
			}
			else
			{
				MessageBox.Show("x nie jest równe 10");
			}
		}

		/// <summary>
		/// Przycisk 3
		/// </summary>
		private void button3_Click(object sender, EventArgs e)
		{
			int someValue = 2;
			string name = "Janek";
			if ((someValue < 3) && (name.Equals("Janek")))
			{
				MessageBox.Show("x jest równe 3 i name jest równe Janek");
			}
			MessageBox.Show("ten wiersz jest wykonywany bez względu na warunki");
		}

		/// <summary>
		/// Przycisk 4
		/// </summary>
		private void button4_Click(object sender, EventArgs e)
		{
			int count = 0;
			while (count < 10)
			{
				count += 1;
			}

			for (int i = 0; i < 5; i++)
			{
				count--;
			}

			MessageBox.Show("Odpowiedź brzmi " + count);
		}

		/// <summary>
		/// Przycisk 5
		/// </summary>
		private void button5_Click(object sender, EventArgs e)
		{
			int result = 0;
			int x = 6;
			while (x > 3)
			{
				result += x;
				x--;
			}

			for (int z = 1; z < 3; z++)
			{
				result += z;
			}

			MessageBox.Show("Zmienna result jest równa " + result);
		}

		/// <summary>
		/// Przycisk 6
		/// </summary>
		private void button6_Click(object sender, EventArgs e)
		{
			string Result = "";

			int x = 3;

			while (x > 0)
			{
				if (x > 2)
				{
					Result += "a";
				}

				x--;
				Result += "-";

				if (x == 2)
				{
					Result += "b c";
				}

				if (x == 1)
				{
					Result += "d";
					x--;
				}
			}

			MessageBox.Show(Result);
		}
	}
}