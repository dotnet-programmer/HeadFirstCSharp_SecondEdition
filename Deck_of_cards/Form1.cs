using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Deck_of_cards
{
	public partial class Form1 : Form
	{
		private readonly Random _random = new Random();

		public Form1()
			=> InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			Card card = new Card((Suits)_random.Next(4), (Values)_random.Next(1, 14));
			MessageBox.Show(card.Name);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string zero = "zero";
			string first = "jeden";
			string second = "dwa";
			string third = "trzy";
			string fourth = "4.2";
			string twopointtwo = "2.2";

			List<string> strings = new List<string>
			{
				zero,
				first,
				second,
				third
			};

			if (strings.Contains("trzy"))
			{
				strings.Add("cztery");
			}

			strings.RemoveAt(2);

			if (strings.Contains("dwa"))
			{
				strings.Add(twopointtwo);
			}

			if (strings.IndexOf("cztery") != 4)
			{
				strings.Add(fourth);
			}

			PrintList(strings);
		}

		public void PrintList(List<string> stringsToPrint)
		{
			string result = "";
			foreach (var item in stringsToPrint)
			{
				result += "\n" + item;
			}
			MessageBox.Show(result);
		}
	}
}