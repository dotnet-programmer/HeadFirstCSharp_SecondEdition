namespace Interface_2
{
	internal class TallGuy : IClown
	{
		public string Name;
		public int Height;

		public void TalkAboutYourself()
			=> System.Windows.Forms.MessageBox.Show("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");

		string IClown.FunnyThingIHave
			=> "Duże buty";

		void IClown.Honk()
			=> System.Windows.Forms.MessageBox.Show("Honk!");
	}
}