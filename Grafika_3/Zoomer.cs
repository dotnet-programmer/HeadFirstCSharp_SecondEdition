using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafika_3
{
	public partial class Zoomer : UserControl
	{
		private readonly Bitmap photo = new Bitmap(@"C:\Users\Michal\Desktop\1634430447_xhdioj_600.jpg");

		public Zoomer() => InitializeComponent();

		private void trackBar1_Scroll(object sender, EventArgs e) => Invalidate();

		private void trackBar2_Scroll(object sender, EventArgs e) => Invalidate();

		private void Zoomer_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);
			g.DrawImage(photo, new Rectangle(10, 10, trackBar1.Value, trackBar2.Value));
		}
	}
}