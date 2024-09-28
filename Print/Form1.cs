using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Print
{
	public partial class Form1 : Form
	{
		private bool _firstPage = true;

		public Form1()
			=> InitializeComponent();

		public void DrawBee(Graphics g, Rectangle r)
			=> g.DrawImage(Properties.Resources.Bee_animation_1, r);

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

		private void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			DrawBee(e.Graphics, new Rectangle(0, 0, 300, 300));
			using (Font font = new Font("Arial", 36, FontStyle.Bold))
			{
				if (_firstPage)
				{
					e.Graphics.DrawString("Pierwsza strona", font, Brushes.Black, 0, 0);
					e.HasMorePages = true;
					_firstPage = false;
				}
				else
				{
					e.Graphics.DrawString("Druga strona", font, Brushes.Black, 0, 0);
					_firstPage = true;
				}
			}
		}
	}
}