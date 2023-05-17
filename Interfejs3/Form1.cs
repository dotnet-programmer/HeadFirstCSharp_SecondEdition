using System;
using System.Windows.Forms;

namespace Interfejs3
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			ScaryScary fingersTheClown = new ScaryScary("duże buty", 14);
			FunnyFunny someFunnyClown = fingersTheClown;
			IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
			someOtherScaryClown.Honk();
		}
	}
}