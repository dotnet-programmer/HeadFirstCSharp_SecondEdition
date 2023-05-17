using System;
using System.Windows.Forms;

namespace Dziedziczenie_test
{
	public partial class Form1 : Form
	{
		private readonly A a = new A();
		private readonly B b = new B();
		private readonly C c = new C();
		private readonly A a2 = new C();
		private string q = "";

		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			q = "";
			q += b.m1();
			q += c.m2();
			q += a.m3();
			MessageBox.Show(q);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			q = "";
			q += c.m1();
			q += c.m2();
			q += c.m3();
			MessageBox.Show(q);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			q = "";
			q += a.m1();
			q += b.m2();
			q += c.m3();
			MessageBox.Show(q);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			q = "";
			q += a2.m1();
			q += a2.m2();
			q += a2.m3();
			//a2.ShowMessage();
			MessageBox.Show(q);
		}
	}
}