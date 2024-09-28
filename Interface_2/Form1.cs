using System;
using System.Windows.Forms;

namespace Interface_2
{
	public partial class Form1 : Form
	{
		public Form1()
			=> InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Adam" };
			tallGuy.TalkAboutYourself();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			IClown tallGuy = new TallGuy() { Height = 274, Name = "Wielkolud" };
			tallGuy.Honk();
			((TallGuy)tallGuy).TalkAboutYourself();
		}
	}
}