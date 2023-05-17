using System;
using System.Windows.Forms;

namespace Bar_Niechlujny_Janek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
			label1.Text = menu.GetMenuItem();
			label2.Text = menu.GetMenuItem();
			label3.Text = menu.GetMenuItem();
			label4.Text = menu.GetMenuItem();
			label5.Text = menu.GetMenuItem();
			label6.Text = menu.GetMenuItem();
		}
	}
}