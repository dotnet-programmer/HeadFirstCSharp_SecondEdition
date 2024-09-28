using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeeControl_UserControl
{
	public partial class Form1 : Form
	{
		private BeeControl _control = null;

		public Form1()
			=> InitializeComponent();

		private void Button1_Click(object sender, EventArgs e)
		{
			if (_control == null)
			{
				_control = new BeeControl() { Location = new Point(100, 100) };
				Controls.Add(_control);
			}
			else
			{
				using (_control)
				{
					Controls.Remove(_control);
				}
				_control = null;
			}
		}
	}
}