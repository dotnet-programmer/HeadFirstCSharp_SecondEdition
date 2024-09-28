using System;
using System.Windows.Forms;

namespace Farmer
{
	public partial class Form1 : Form
	{
		private readonly Farmer _farmer;

		public Form1()
		{
			InitializeComponent();
			_farmer = new Farmer(15, 30);
		}

		private void button1_Click(object sender, EventArgs e)
			=> Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów", _farmer.BagsOfFeed, _farmer.NumberOfCows);

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
			=> _farmer.NumberOfCows = (int)numericUpDown1.Value;
	}
}