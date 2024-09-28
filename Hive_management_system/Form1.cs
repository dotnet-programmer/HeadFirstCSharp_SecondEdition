using System;
using System.Windows.Forms;

namespace Hive_management_system
{
	public partial class Form1 : Form
	{
		private readonly Queen _queen;

		public Form1()
		{
			InitializeComponent();

			Worker[] workersTab = new Worker[4];
			workersTab[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
			workersTab[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
			workersTab[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z żądłami" });
			workersTab[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymywanie ula", "Patrol z żądłami" });
			_queen = new Queen(workersTab);
		}

		private void AssignWorkBtn_Click(object sender, EventArgs e)
		{
			if (_queen.AssignWork(WorkerBeeJob.Text, (int)Shifts.Value))
			{
				MessageBox.Show("Zadanie '" + WorkerBeeJob.Text + "' będzie ukończone za " + (int)Shifts.Value + " zmiany");
			}
			else
			{
				MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + WorkerBeeJob.Text + "'", "Królowa pszczół mówi...");
			}
		}

		private void NextShift_Click(object sender, EventArgs e)
			=> ReportTxt.Text = _queen.WorkTheNextShift();
	}
}