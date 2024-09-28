using System;
using System.Windows.Forms;

namespace Inheritance
{
	public partial class Form1 : Form
	{
		public Form1()
			=> InitializeComponent();

		private void Button1_Click(object sender, EventArgs e)
		{
			Dog dog = new Dog
			{
				age = 5
			};
			Label1.Text = $"From class Animal: age = {dog.GetAge()}, hunger = {dog.GetHunger()}, from Dog: size = {dog.GetSize()}";
		}
	}
}