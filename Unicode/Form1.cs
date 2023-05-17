using System;
using System.IO;
using System.Windows.Forms;

namespace Unicode
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			File.WriteAllText("eureka.txt", "Eureka!");
			byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
			foreach (var item in eurekaBytes)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			File.WriteAllText("eureka.txt", "Eureka!");
			byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
			foreach (var item in eurekaBytes)
			{
				Console.Write("{0:x2} ", item);
			}
			Console.WriteLine();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			File.WriteAllText("eureka.txt", "םולש");
			byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
			foreach (var item in eurekaBytes)
			{
				Console.Write("{0:x2} ", item);
			}
			Console.WriteLine();
		}
	}
}