namespace Slownik
{
	internal class JerseyNumber
	{
		public string Player { get; private set; }
		public int YearRetired { get; private set; }

		public JerseyNumber(string player, int numberRetired)
		{
			Player = player;
			YearRetired = numberRetired;
		}
	}
}