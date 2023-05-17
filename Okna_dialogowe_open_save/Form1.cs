using System;
using System.IO;
using System.Windows.Forms;

namespace Okna_dialogowe_open_save
{
	public partial class Form1 : Form
	{
		private string name;

		public Form1() => InitializeComponent();

		private void BtnOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				name = openFileDialog1.FileName;
				textBox1.Clear();
				textBox1.Text = File.ReadAllText(name);
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				name = saveFileDialog1.FileName;
				File.WriteAllText(name, textBox1.Text);
			}
		}
	}
}