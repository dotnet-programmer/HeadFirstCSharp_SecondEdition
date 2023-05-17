using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafika_2
{
	public partial class Form1 : Form
	{
		private bool isClicked = false;

		public Form1() => InitializeComponent();

		private void Form1_Click(object sender, EventArgs e)
		{
			if (!isClicked)
			{
				FillPolygon();
				isClicked = true;
			}
			else
			{
				ShownFill();
				isClicked = false;
			}
		}

		private void FillPolygon()
		{
			using (Graphics g = this.CreateGraphics())
			{
				DrawGrid(g);

				g.FillPolygon(Brushes.Black, new Point[]
				{ new Point(60,40), new Point(140,80), new Point(200,40), new Point(300,80), new Point(380,60), new Point(340,140), new Point(320,180), new Point(380,240),
					new Point(320,300), new Point(340,340), new Point(240,320), new Point(180,340),
					new Point(20,320), new Point(60,280), new Point(100,240), new Point(40,220), new Point(80,160)  }
				);

				using (Font big = new Font("Times New Roman", 24, FontStyle.Italic))
				{
					g.DrawString("Bum!", big, Brushes.White, new Point(80, 80));
					g.DrawString("Bum!", big, Brushes.White, new Point(120, 120));
					g.DrawString("Bum!", big, Brushes.White, new Point(160, 160));
					g.DrawString("Bum!", big, Brushes.White, new Point(200, 200));
					g.DrawString("Bum!", big, Brushes.White, new Point(240, 240));
				}
			}
		}

		private void ShownFill()
		{
			using (Graphics graphics = this.CreateGraphics())
			using (Pen pen = new Pen(Brushes.Black, 3.0F))
			{
				DrawGrid(graphics);

				graphics.DrawCurve(pen, new Point[] { new Point(80, 60), new Point(200, 40), new Point(180, 60), new Point(300, 40) });
				graphics.DrawCurve(pen, new Point[] { new Point(300, 180), new Point(180, 200), new Point(200, 180), new Point(80, 200) });

				graphics.DrawLine(pen, 300, 40, 300, 180);
				graphics.DrawLine(pen, 80, 60, 80, 200);
				graphics.DrawEllipse(pen, 40, 40, 20, 20);
				graphics.DrawRectangle(pen, 40, 60, 20, 300);
				graphics.DrawLine(pen, 60, 60, 80, 60);
				graphics.DrawLine(pen, 60, 200, 80, 200);
			}
		}

		private void DrawGrid(Graphics graphics)
		{
			using (Font font = new Font("Arial", 6, FontStyle.Regular))
			{
				graphics.Clear(Color.White);
				for (int x = 0; x < this.Width; x += 20)
				{
					graphics.DrawLine(Pens.Black, new Point(x, 0), new Point(x, Height));
					graphics.DrawString(x.ToString(), font, Brushes.Black, new Point(x + 1, 1));
				}
				for (int y = 0; y < this.Height; y += 20)
				{
					graphics.DrawLine(new Pen(Brushes.Black, 1.0F), new Point(0, y), new Point(Width, y));
					graphics.DrawString(y.ToString(), font, Brushes.Black, new Point(1, y + 1));
				}
			}
		}

		private void Form1_Shown(object sender, EventArgs e) => ShownFill();
	}
}