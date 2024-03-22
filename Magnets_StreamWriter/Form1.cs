using System;
using System.IO;
using System.Windows.Forms;

namespace Magnets_StreamWriter
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			Flobbo f = new Flobbo("niebiesko-źółta");
			StreamWriter sw = f.Snobbo();
			f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
		}
	}
}