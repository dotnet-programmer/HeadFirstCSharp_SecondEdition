using System;
using System.Windows.Forms;

namespace Zagadkowy_basen_2
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			string result = "";
			Echo e1 = new Echo();
			Echo e2 = new Echo(); //
			int x = 0;
			while (x < 4) //
			{
				result += e1.hello() + "\n";
				e1.count++; // 1, 2, 3, 4
				if (x == 4) //
				{
					e2.count += 1;
				}
				if (x < 5) //
				{
					e2.count += e1.count;                                         // 0+1 | 1+2 | 3+3 | 6+4   //  1+1 | 3+2 | 6+3 | 10+4
				}
				x += 1;
			}
			MessageBox.Show(result + "Licznik: " + e2.count);
		}

		public class Echo //
		{
			public int count = 0; //

			public string hello() //
=> "witaaaj...";
		}
	}
}