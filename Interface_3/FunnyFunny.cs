namespace Interface_3
{
	internal class FunnyFunny : IClown
	{
		private readonly string _funnyThingIHave;

		public FunnyFunny(string funnyThingIHave) 
			=> _funnyThingIHave = funnyThingIHave;

		public string FunnyThingIHave 
			=> "Kwa, kwa! Mam " + _funnyThingIHave;

		public void Honk() 
			=> System.Windows.Forms.MessageBox.Show(FunnyThingIHave);
	}
}