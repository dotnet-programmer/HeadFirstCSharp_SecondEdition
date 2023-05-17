using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symulator_ula
{
	public partial class BeeControl : UserControl
	{
		private int cell = 0;

		public BeeControl()
		{
			InitializeComponent();
			ResizeCells();
		}

		private void animationTimer_Tick(object sender, EventArgs e)
		{
			cell++;
			switch (cell)
			{
				case 1:
					BackgroundImage = cells[0];
					break;
				case 2:
					BackgroundImage = cells[1];
					break;
				case 3:
					BackgroundImage = cells[2];
					break;
				case 4:
					BackgroundImage = cells[3];
					break;
				case 5:
					BackgroundImage = cells[2];
					break;
				default:
					BackgroundImage = cells[1];
					cell = 0;
					break;
			}
		}

		private readonly Bitmap[] cells = new Bitmap[4];

		private void ResizeCells()
		{
			cells[0] = Renderer.ResizeImage(Properties.Resources.Bee_animation_1, Width, Height);
			cells[1] = Renderer.ResizeImage(Properties.Resources.Bee_animation_2, Width, Height);
			cells[2] = Renderer.ResizeImage(Properties.Resources.Bee_animation_3, Width, Height);
			cells[3] = Renderer.ResizeImage(Properties.Resources.Bee_animation_4, Width, Height);
		}

		private void BeeControl_Resize(object sender, EventArgs e) => ResizeCells();
	}
}