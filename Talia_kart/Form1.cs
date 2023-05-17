using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Talia_kart
{
	public partial class Form1 : Form
	{
		private readonly Random random = new Random();

		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
			MessageBox.Show(card.Name);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string zilch = "zero";
			string first = "jeden";
			string second = "dwa";
			string third = "trzy";
			string fourth = "4.2";
			string twopointtwo = "2.2";

			List<string> a = new List<string>
			{
				zilch,
				first,
				second,
				third
			};

			if (a.Contains("trzy"))
			{
				a.Add("cztery");
			}

			a.RemoveAt(2);

			if (a.Contains("dwa"))
			{
				a.Add(twopointtwo);
			}

			if (a.IndexOf("cztery") != 4)
			{
				a.Add(fourth);
			}

			printL(a);
		}

		public void printL(List<string> a)
		{
			string result = "";
			foreach (var item in a)
			{
				result += "\n" + item;
			}

			MessageBox.Show(result);
		}
	}
}