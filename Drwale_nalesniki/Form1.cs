using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Drwale_nalesniki
{
	public partial class Form1 : Form
	{
		private readonly Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

		public Form1() => InitializeComponent();

		private void AddFlapjackBtn_Click(object sender, EventArgs e)
		{
			Flapjack food = Crispy.Checked
				? Flapjack.Chrupkiego
				: Soggy.Checked ? Flapjack.Wilgotnego : Browned.Checked ? Flapjack.Rumianego : Flapjack.Bananowego;

			//Lumberjack currentLumberjack = breakfastLine.Peek();
			//currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
			breakfastLine.Peek().TakeFlapjacks(food, (int)howMany.Value);
			RedrawList();
		}

		private void RedrawList()
		{
			int i = 1;
			Line.Items.Clear();
			foreach (var item in breakfastLine)
			{
				Line.Items.Add(i + ". " + item.Name);
				i++;
			}

			if (breakfastLine.Count == 0)
			{
				groupBox1.Enabled = false;
				NextInLine.Text = "";
			}
			else
			{
				groupBox1.Enabled = true;
				Lumberjack currentLumberjack = breakfastLine.Peek();
				NextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
			}
		}

		private void NextLumberjackBtn_Click(object sender, EventArgs e)
		{
			//Lumberjack currentLumberjack = breakfastLine.Dequeue();
			//currentLumberjack.EatFlapjacks();
			breakfastLine.Dequeue().EatFlapjacks();
			RedrawList();
		}

		private void AddLumberjackBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(NameText.Text))
			{
				MessageBox.Show("Podaj imie drwala");
				return;
			}

			breakfastLine.Enqueue(new Lumberjack(NameText.Text));
			NameText.Text = "";
			RedrawList();
		}
	}
}