using System;
using System.Windows.Forms;

namespace Grafika_3
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		protected override void OnPaint(PaintEventArgs e)
		{
			Console.WriteLine("OnPaint {0} {1}", DateTime.Now, e.ClipRectangle);
			base.OnPaint(e);
		}
	}
}