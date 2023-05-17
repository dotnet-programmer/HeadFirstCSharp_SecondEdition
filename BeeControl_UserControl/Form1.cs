using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeeControl_UserControl
{
	public partial class Form1 : Form
	{
		private BeeControl control = null;

		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			if (control == null)
			{
				control = new BeeControl() { Location = new Point(100, 100) };
				Controls.Add(control);
			}
			else
			{
				using (control)
				{
					Controls.Remove(control);
				}
				control = null;
			}
		}
	}
}