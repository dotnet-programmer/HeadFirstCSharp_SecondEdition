namespace Delegates_2
{
	internal class Suzanne
	{
		public GetSecretIngredient MySecretIngredientMethod
			=> new GetSecretIngredient(SuzannesSecretIngredient);

		private string SuzannesSecretIngredient(int amount)
			=> amount.ToString() + " dekagramów goździków";
	}
}