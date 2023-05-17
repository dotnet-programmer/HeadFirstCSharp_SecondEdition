using System;
using System.Windows.Forms;

namespace Slonie
{
	public partial class Form1 : Form
	{
		private Elephant slon1;
		private Elephant slon2;

		public Form1()
		{
			InitializeComponent();

			slon1 = new Elephant() { Name = "Kunegunda", EarSize = 33 };
			slon2 = new Elephant() { Name = "Zenobia", EarSize = 40 };
		}

		/// <summary>
		/// Show info about Kunegunda
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e) => slon1.WhoAmI();

		/// <summary>
		/// Show info about Zenobia
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e) => slon2.WhoAmI();

		/// <summary>
		/// Switch ear size between elephants
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			Elephant tmpElephant;
			tmpElephant = slon1;
			slon1 = slon2;
			slon2 = tmpElephant;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			slon1.TellMe("Cześć", slon2);

			slon1 = slon2;
			slon1.EarSize = 4321;
			slon1.WhoAmI();
		}
	}
}