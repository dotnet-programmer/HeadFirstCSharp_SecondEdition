using System;
using System.Windows.Forms;

namespace Delegates_2
{
	public partial class Form1 : Form
	{
		private GetSecretIngredient _ingredientMethod = null;
		private readonly Suzanne _suzanne = new Suzanne();
		private readonly Amy _amy = new Amy();

		public Form1()
			=> InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			if (_ingredientMethod != null)
			{
				Console.WriteLine("Dodam " + _ingredientMethod((int)numericUpDown1.Value));
			}
			else
			{
				Console.WriteLine("Nie mam tajnego składnika");
			}
		}

		private void button2_Click(object sender, EventArgs e)
			=> _ingredientMethod = new GetSecretIngredient(_suzanne.MySecretIngredientMethod);

		private void button3_Click(object sender, EventArgs e)
			=> _ingredientMethod = new GetSecretIngredient(_amy.MySecretIngredientMethod);
	}
}