namespace Delegates_2
{
	internal class Amy
	{
		public GetSecretIngredient MySecretIngredientMethod 
			=> new GetSecretIngredient(AmysSecretIngredient);

		private string AmysSecretIngredient(int amount) 
			=> amount < 10 ? amount.ToString() + " puszek sardynek -- potrzebujesz więcej!" : amount.ToString() + " puszek sardynek";
	}
}