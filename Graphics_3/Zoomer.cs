using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics_3
{
	public partial class Zoomer : UserControl
	{
		private readonly Bitmap _photo = new Bitmap("");

		public Zoomer() 
			=> InitializeComponent();

		private void trackBar1_Scroll(object sender, EventArgs e) 
			=> Invalidate();

		private void trackBar2_Scroll(object sender, EventArgs e) 
			=> Invalidate();

		private void Zoomer_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);
			g.DrawImage(_photo, new Rectangle(10, 10, trackBar1.Value, trackBar2.Value));
		}
	}
}