using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeeControl
{
	public partial class Form1 : Form
	{
		private BeeControl _control = null;
		private int _cell = 0;

		public Form1()
		{
			InitializeComponent();
			timer1.Start();
		}

		private void button1_Click(object sender, EventArgs e)
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			_cell++;
			switch (_cell)
			{
				case 1:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_1;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				case 2:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_2;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				case 3:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_3;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				case 4:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_4;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				case 5:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_3;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				default:
					pictureBox1.BackgroundImage = Properties.Resources.Bee_animation_2;
					pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
					_cell = 0;
					break;
			}
		}
	}
}