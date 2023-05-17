using System;
using System.Windows.Forms;

namespace timer_test
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void timer1_Tick(object sender, EventArgs e) => Console.WriteLine(DateTime.Now.ToString());

		private void button1_Click(object sender, EventArgs e) => timer1.Enabled = !timer1.Enabled;

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Start();
			Console.WriteLine("Enabled = " + timer1.Enabled);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			Console.WriteLine("Enabled = " + timer1.Enabled);
		}
	}
}