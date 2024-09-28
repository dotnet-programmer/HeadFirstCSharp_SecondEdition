using System;
using System.Drawing;
using System.Windows.Forms;

namespace If_else_statements
{
	public partial class Form1 : Form
	{
		public Form1()
			=> InitializeComponent();

		/// <summary>
		/// Zmiana koloru tekstu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnChangeColor_Click(object sender, EventArgs e)
		{
			if (CbxChangeColor.Checked == true)
			{
				LText1.BackColor = LText1.BackColor == Color.Red ? Color.Yellow : Color.Red;
			}
			else
			{
				MessageBox.Show("Pole wyboru nie jest zaznaczone");
			}
		}
	}
}