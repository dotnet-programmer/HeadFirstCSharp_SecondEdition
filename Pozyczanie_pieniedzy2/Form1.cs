using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Pozyczanie_pieniedzy
{
	public partial class Form1 : Form
	{
		private readonly Guy bob;
		private Guy joe;
		private int bank = 100;

		public void UpdateForm()
		{
			TxtJoe.Text = joe.Name + " ma " + joe.Cash + " zł";
			TxtBob.Text = bob.Name + " ma " + bob.Cash + " zł";
			TxtBank.Text = "Bank ma " + bank + " zł";
		}

		public Form1()
		{
			InitializeComponent();

			bob = new Guy
			{
				Name = "Bob",
				Cash = 100
			};

			joe = new Guy
			{
				Name = "Joe",
				Cash = 50
			};

			UpdateForm();
		}

		/// <summary>
		/// Daj kase Joemu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			if (bank >= 10)
			{
				bank -= joe.RecieveCash(10);
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
			bank += bob.GiveCash(5);
			UpdateForm();
		}

		/// <summary>
		/// Joe daje Bobowi
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			bob.RecieveCash(joe.GiveCash(10));
			UpdateForm();
		}

		/// <summary>
		/// Bob daje Joemu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			joe.RecieveCash(bob.GiveCash(5));
			UpdateForm();
		}

		private void BtnSaveJoe_Click(object sender, EventArgs e)
		{
			using (Stream output = File.Create("Plik_Joe.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, joe);
			}
		}

		private void BtnLoadJoe_Click(object sender, EventArgs e)
		{
			using (Stream input = File.OpenRead("Plik_Joe.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				joe = (Guy)formatter.Deserialize(input);
			}
			UpdateForm();
		}
	}
}