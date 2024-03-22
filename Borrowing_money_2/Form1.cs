using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Borrowing_money_2
{
	public partial class Form1 : Form
	{
		private readonly Guy _bob;
		private Guy _joe;
		private int _bank = 100;

		public Form1()
		{
			InitializeComponent();

			_bob = new Guy
			{
				Name = "Bob",
				Cash = 100
			};

			_joe = new Guy
			{
				Name = "Joe",
				Cash = 50
			};

			UpdateForm();
		}

		public void UpdateForm()
		{
			TxtJoe.Text = _joe.Name + " ma " + _joe.Cash + " zł";
			TxtBob.Text = _bob.Name + " ma " + _bob.Cash + " zł";
			TxtBank.Text = "Bank ma " + _bank + " zł";
		}

		/// <summary>
		/// Daj pieniądze Joemu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			if (_bank >= 10)
			{
				_bank -= _joe.RecieveCash(10);
				UpdateForm();
			}
			else
			{
				MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
			}
		}

		/// <summary>
		/// Wez od Boba
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			_bank += _bob.GiveCash(5);
			UpdateForm();
		}

		/// <summary>
		/// Joe daje Bobowi
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			_bob.RecieveCash(_joe.GiveCash(10));
			UpdateForm();
		}

		/// <summary>
		/// Bob daje Joemu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			_joe.RecieveCash(_bob.GiveCash(5));
			UpdateForm();
		}

		private void BtnSaveJoe_Click(object sender, EventArgs e)
		{
			using (Stream output = File.Create("Plik_Joe.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, _joe);
			}
		}

		private void BtnLoadJoe_Click(object sender, EventArgs e)
		{
			using (Stream input = File.OpenRead("Plik_Joe.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				_joe = (Guy)formatter.Deserialize(input);
			}
			UpdateForm();
		}
	}
}