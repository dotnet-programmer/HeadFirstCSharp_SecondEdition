using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics_1
{
	public partial class Form1 : Form
	{
		public Form1() 
			=> InitializeComponent();

		private void Form1_Resize(object sender, EventArgs e) 
			=> DrawMyPicture();

		private void Form1_Shown(object sender, EventArgs e) 
			=> DrawMyPicture();

		private void DrawMyPicture()
		{
			using (Graphics g = CreateGraphics())
			using (Pen thickBlackPen = new Pen(Brushes.Black, 3.0F))
			using (Font font = new Font("Arial", 16, FontStyle.Italic))
			{
				g.FillRectangle(Brushes.SkyBlue, ClientRectangle);
				g.DrawImage(Properties.Resources.Bee_animation_1, 50, 20, 75, 75);
				g.DrawImage(Properties.Resources.Flower, 10, 130, 100, 150);
				g.DrawLines(thickBlackPen, new Point[] { new Point(130, 110), new Point(120, 160), new Point(155, 163) });
				g.DrawCurve(thickBlackPen, new Point[] { new Point(120, 160), new Point(175, 120), new Point(215, 70) });
				SizeF size = g.MeasureString("Tu jest nektar", font);
				g.DrawString("Tu jest nektar", font, Brushes.Red, new Point(215 - (int)size.Width / 2, 70 - (int)size.Height));

				Point leftPoint = new Point(ClientRectangle.X, ClientRectangle.Y);
				Point rightPoint = new Point(ClientRectangle.Width, ClientRectangle.Height);

				g.DrawLines(thickBlackPen, new Point[] { leftPoint, rightPoint });

				Point leftMiddlePoint = new Point(ClientRectangle.X + 40, ClientRectangle.Height / 2);
				Point rightMiddlePoint = new Point(ClientRectangle.Width - 40, ClientRectangle.Height / 2);
				g.DrawLines(thickBlackPen, new Point[] { leftMiddlePoint, rightMiddlePoint });
			}
		}
	}
}