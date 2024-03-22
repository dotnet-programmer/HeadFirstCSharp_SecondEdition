using System;
using System.IO;
using System.Windows.Forms;

namespace Excuses_management_2
{
	public partial class Form1 : Form
	{
		private Excuse _currentExcuse = new Excuse();
		private string _selectedFolder = "";
		private bool _isFormChanged = false;
		private readonly Random _random = new Random();

		public Form1()
		{
			InitializeComponent();
			_currentExcuse.LastUsed = DateLastUse.Value;
		}

		private void UpdateForm(bool isChanged)
		{
			if (!isChanged)
			{
				TxtExcuse.Text = _currentExcuse.Description;
				TxtEffect.Text = _currentExcuse.Results;
				DateLastUse.Value = _currentExcuse.LastUsed;
				if (!string.IsNullOrEmpty(_currentExcuse.ExcusePath))
				{
					TxtFileDate.Text = File.GetLastWriteTime(_currentExcuse.ExcusePath).ToString();
				}

				Text = "Zarządzanie wymówkami";
			}
			else
			{
				Text = "Zarządzanie wymówkami *";
			}

			_isFormChanged = isChanged;
		}

		private bool CheckChanged()
		{
			if (_isFormChanged)
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
			folderBrowserDialog1.SelectedPath = _selectedFolder;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				_selectedFolder = folderBrowserDialog1.SelectedPath;
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

			saveFileDialog1.InitialDirectory = _selectedFolder;
			saveFileDialog1.FileName = TxtExcuse.Text + ".excuse";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_currentExcuse.Save(saveFileDialog1.FileName);
				UpdateForm(false);
				MessageBox.Show("Wymówka zapisana");
			}
		}

		private void BtnOpen_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				openFileDialog1.InitialDirectory = _selectedFolder;
				openFileDialog1.FileName = TxtExcuse.Text + ".excuse";
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					_currentExcuse = new Excuse(openFileDialog1.FileName);
					UpdateForm(false);
				}
			}
		}

		private void BtnRandomExcuse_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				_currentExcuse = new Excuse(_random, _selectedFolder);
				UpdateForm(false);
			}
		}

		private void TxtExcuse_TextChanged(object sender, EventArgs e)
		{
			_currentExcuse.Description = TxtExcuse.Text;
			UpdateForm(true);
		}

		private void TxtEffect_TextChanged(object sender, EventArgs e)
		{
			_currentExcuse.Results = TxtEffect.Text;
			UpdateForm(true);
		}

		private void DateLastUse_ValueChanged(object sender, EventArgs e)
		{
			_currentExcuse.LastUsed = DateLastUse.Value;
			UpdateForm(true);
		}
	}
}