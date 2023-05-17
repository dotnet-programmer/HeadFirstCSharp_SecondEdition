using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blyskotliwy_projekt
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private const int START_COLOR = 0;
		private const int FINISH_COLOR = 254;
		private const int RGB_COLOR = 255;
		private const int SLEEP_TIME = 3;

		private void BtnStart_Click(object sender, EventArgs e)
		{
			while (Visible)
			{
				for (int i = START_COLOR; i < FINISH_COLOR && Visible; i++)
				{
					this.BackColor = Color.FromArgb(i, RGB_COLOR - i, i);
					Application.DoEvents();
					System.Threading.Thread.Sleep(SLEEP_TIME);
				}

				for (int i = FINISH_COLOR; i > START_COLOR && Visible; i--)
				{
					this.BackColor = Color.FromArgb(i, RGB_COLOR - i, i);
					Application.DoEvents();
					System.Threading.Thread.Sleep(SLEEP_TIME);
				}
			}
		}
	}
}