using System;
using System.Windows.Forms;

namespace Delegaty_2
{
	public partial class Form1 : Form
	{
		private GetSecretIngredient ingredientMethod = null;
		private readonly Suzanne suzanne = new Suzanne();
		private readonly Amy amy = new Amy();

		public Form1() => InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			if (ingredientMethod != null)
			{
				Console.WriteLine("Dodam " + ingredientMethod((int)numericUpDown1.Value));
			}
			else
			{
				Console.WriteLine("Nie mam tajnego składnika");
			}
		}

		private void button2_Click(object sender, EventArgs e) => ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);

		private void button3_Click(object sender, EventArgs e) => ingredientMethod = new GetSecretIngredient(amy.MySecretIngredientMethod);
	}
}