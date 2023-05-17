using System;
using System.Windows.Forms;

namespace Kalkulator_kosztow_podrozy
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			if (EdtFinish.Value <= EdtStart.Value)
			{
				LblDistanceValue.Text = "0";
				LblCashValue.Text = "0";
				MessageBox.Show("Końcowa wartość musi być większa od początkowej!", "Nie mogę obliczyć odległości");
				return;
			}

			int distance = (int)(EdtFinish.Value - EdtStart.Value);
			double cashToReturn = distance * 0.39;

			LblDistanceValue.Text = distance.ToString() + " km";
			LblCashValue.Text = cashToReturn.ToString() + " zł";

			//if (EdtFinish.Value > EdtStart.Value)
			//{
			//	int distance = (int)(EdtFinish.Value - EdtStart.Value);
			//	double cashToReturn = distance * 0.39;
			//	LblCashValue.Text = cashToReturn.ToString();
			//}
			//else
			//{
			//	LblCashValue.Text = "0";
			//	MessageBox.Show("Końcowa wartość musi być większa od początkowej!");
			//}
		}
	}
}