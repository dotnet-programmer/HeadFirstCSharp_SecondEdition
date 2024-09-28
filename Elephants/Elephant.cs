namespace Elephants
{
	internal class Elephant
	{
		public string Name;
		public int EarSize;

		/// <summary>
		/// Show summary about elephant
		/// </summary>
		public void WhoAmI()
			=> System.Windows.Forms.MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokości", Name + " mówi...");

		public void TellMe(string message, Elephant whoSaidIt)
			=> System.Windows.Forms.MessageBox.Show(whoSaidIt.Name + " mówi: " + message);

		public void SpeakTo(Elephant talkTo, string message)
			=> talkTo.TellMe(message, this);
	}
}