using System;
using System.Windows.Forms;

namespace Contacts
{
	public partial class Form1 : Form
	{
		public Form1() 
			=> InitializeComponent();

		private void pictureBox1_Click(object sender, EventArgs e) 
			=> MessageBox.Show("Lista kontaktów v 1.0.\nAutor: Ja", "O programie");

		private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.peopleBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.contactDBDataSet);
		}

		private void peopleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.peopleBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.contactDBDataSet);
		}

		private void peopleBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
		{
			this.Validate();
			this.peopleBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.contactDBDataSet);
		}

		// This line of code loads the data into the table 'contactDBDataSet.People'
		private void Form1_Load(object sender, EventArgs e) 
			=> this.peopleTableAdapter.Fill(this.contactDBDataSet.People);
	}
}