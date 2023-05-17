using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Drukowanie
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			PrintDocument document = new PrintDocument();
			document.PrintPage += Document_PrintPage;
			PrintPreviewDialog previewDialog = new PrintPreviewDialog
			{
				Document = document
			};
			previewDialog.ShowDialog(this);
		}

		private bool firstPage = true;

		private void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			DrawBee(e.Graphics, new Rectangle(0, 0, 300, 300));
			using (Font font = new Font("Arial", 36, FontStyle.Bold))
			{
				if (firstPage)
				{
					e.Graphics.DrawString("Pierwsza strona", font, Brushes.Black, 0, 0);
					e.HasMorePages = true;
					firstPage = false;
				}
				else
				{
					e.Graphics.DrawString("Druga strona", font, Brushes.Black, 0, 0);
					firstPage = true;
				}
			}
		}

		public void DrawBee(Graphics g, Rectangle r) => g.DrawImage(Properties.Resources.Bee_animation_1, r);
	}
}