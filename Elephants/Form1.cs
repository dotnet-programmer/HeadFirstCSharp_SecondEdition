using System;
using System.Windows.Forms;

namespace Elephants
{
	public partial class Form1 : Form
	{
		private Elephant _elephant1;
		private Elephant _elephant2;

		public Form1()
		{
			InitializeComponent();

			_elephant1 = new Elephant() { Name = "Kunegunda", EarSize = 33 };
			_elephant2 = new Elephant() { Name = "Zenobia", EarSize = 40 };
		}

		/// <summary>
		/// Show info about Kunegunda
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
			=> _elephant1.WhoAmI();

		/// <summary>
		/// Show info about Zenobia
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
			=> _elephant2.WhoAmI();

		/// <summary>
		/// Switch ear size between elephants
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			Elephant tmpElephant = _elephant1;
			_elephant1 = _elephant2;
			_elephant2 = tmpElephant;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			_elephant1.TellMe("Cześć", _elephant2);
			_elephant1 = _elephant2;
			_elephant1.EarSize = 4321;
			_elephant1.WhoAmI();
		}
	}
}