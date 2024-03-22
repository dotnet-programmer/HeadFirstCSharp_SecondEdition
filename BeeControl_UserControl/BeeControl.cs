using System;
using System.Windows.Forms;

namespace BeeControl_UserControl
{
	public partial class BeeControl : UserControl
	{
		private int _cell = 0;

		public BeeControl() => InitializeComponent();

		private void animationTimer_Tick(object sender, EventArgs e)
		{
			_cell++;
			switch (_cell)
			{
				case 1:
					BackgroundImage = Properties.Resources.Bee_animation_1;
					break;
				case 2:
					BackgroundImage = Properties.Resources.Bee_animation_2;
					break;
				case 3:
					BackgroundImage = Properties.Resources.Bee_animation_3;
					break;
				case 4:
					BackgroundImage = Properties.Resources.Bee_animation_4;
					break;
				case 5:
					BackgroundImage = Properties.Resources.Bee_animation_3;
					break;
				default:
					BackgroundImage = Properties.Resources.Bee_animation_2;
					_cell = 0;
					break;
			}
		}
	}
}