namespace Interfejs3
{
	internal class FunnyFunny : IClown
	{
		public FunnyFunny(string funnyThingIHave) => this.funnyThingIHave = funnyThingIHave;

		private readonly string funnyThingIHave;
		public string FunnyThingIHave => "Kwa, kwa! Mam " + funnyThingIHave;

		public void Honk() => System.Windows.Forms.MessageBox.Show(FunnyThingIHave);
	}
}