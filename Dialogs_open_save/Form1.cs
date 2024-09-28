using System;
using System.IO;
using System.Windows.Forms;

namespace Dialogs_open_save
{
	public partial class Form1 : Form
	{
		private string _name;

		public Form1()
			=> InitializeComponent();

		private void BtnOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_name = openFileDialog1.FileName;
				textBox1.Clear();
				textBox1.Text = File.ReadAllText(_name);
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_name = saveFileDialog1.FileName;
				File.WriteAllText(_name, textBox1.Text);
			}
		}
	}
}