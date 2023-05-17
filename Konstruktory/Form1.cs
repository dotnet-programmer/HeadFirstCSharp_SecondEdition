using System;
using System.Windows.Forms;

namespace Konstruktory
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			MyBaseClass myBaseClass = new MyBaseClass("Jakiś parametr");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MySubclass mySubclass = new MySubclass("Jakiś parametr", 666);
		}
	}
}