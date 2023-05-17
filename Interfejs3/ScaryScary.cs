namespace Interfejs3
{
	internal class ScaryScary : FunnyFunny, IScaryClown
	{
		private readonly int numberOfScaryThings;

		public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave) => this.numberOfScaryThings = numberOfScaryThings;

		public string ScaryThingIHave => "Mam " + numberOfScaryThings + " pająków";

		public void ScareLittleChildren()
		{
			System.Windows.Forms.MessageBox.Show("Buu! Mam cię!");
			System.Windows.Forms.MessageBox.Show("Nie możesz mieć mojego " + base.FunnyThingIHave);
		}
	}
}