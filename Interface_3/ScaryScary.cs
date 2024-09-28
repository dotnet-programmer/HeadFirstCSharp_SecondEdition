namespace Interface_3
{
	internal class ScaryScary : FunnyFunny, IScaryClown
	{
		private readonly int _numberOfScaryThings;

		public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
			=> _numberOfScaryThings = numberOfScaryThings;

		public string ScaryThingIHave
			=> "Mam " + _numberOfScaryThings + " pająków";

		public void ScareLittleChildren()
		{
			System.Windows.Forms.MessageBox.Show("Buu! Mam cię!");
			System.Windows.Forms.MessageBox.Show("Nie możesz mieć mojego " + base.FunnyThingIHave);
		}
	}
}