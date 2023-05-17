using System;
using System.IO;
using System.Windows.Forms;

namespace Zarzadzanie_wymowkami
{
	public partial class Form1 : Form
	{
		private Excuse currentExcuse = new Excuse();
		private string selectedFolder = "";
		private bool isFormChanged = false;
		private readonly Random random = new Random();

		public Form1()
		{
			InitializeComponent();
			currentExcuse.LastUsed = DateLastUse.Value;
		}

		private void UpdateForm(bool isChanged)
		{
			if (!isChanged)
			{
				TxtExcuse.Text = currentExcuse.Description;
				TxtEffect.Text = currentExcuse.Results;
				DateLastUse.Value = currentExcuse.LastUsed;
				if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
				{
					TxtFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
				}

				Text = "Zarządzanie wymówkami";
			}
			else
			{
				Text = "Zarządzanie wymówkami *";
			}

			isFormChanged = isChanged;
		}

		private bool CheckChanged()
		{
			if (isFormChanged)
			{
				if (MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
					== DialogResult.No)
				{
					return false;
				}
			}

			return true;
		}

		private void BtnDirectory_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = selectedFolder;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				selectedFolder = folderBrowserDialog1.SelectedPath;
				BtnSave.Enabled = BtnOpen.Enabled = BtnRandomExcuse.Enabled = true;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxtExcuse.Text) || string.IsNullOrEmpty(TxtEffect.Text))
			{
				MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			saveFileDialog1.InitialDirectory = selectedFolder;
			saveFileDialog1.FileName = TxtExcuse.Text + ".excuse";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				currentExcuse.Save(saveFileDialog1.FileName);
				UpdateForm(false);
				MessageBox.Show("Wymówka zapisana");
			}
		}

		private void BtnOpen_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				openFileDialog1.InitialDirectory = selectedFolder;
				openFileDialog1.FileName = TxtExcuse.Text + ".excuse";
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					currentExcuse = new Excuse(openFileDialog1.FileName);
					UpdateForm(false);
				}
			}
		}

		private void BtnRandomExcuse_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				currentExcuse = new Excuse(random, selectedFolder);
				UpdateForm(false);
			}
		}

		private void TxtExcuse_TextChanged(object sender, EventArgs e)
		{
			currentExcuse.Description = TxtExcuse.Text;
			UpdateForm(true);
		}

		private void TxtEffect_TextChanged(object sender, EventArgs e)
		{
			currentExcuse.Results = TxtEffect.Text;
			UpdateForm(true);
		}

		private void DateLastUse_ValueChanged(object sender, EventArgs e)
		{
			currentExcuse.LastUsed = DateLastUse.Value;
			UpdateForm(true);
		}
	}
}