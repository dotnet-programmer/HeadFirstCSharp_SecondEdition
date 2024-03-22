namespace Dictionary
{
	internal class JerseyNumber
	{
		public JerseyNumber(string player, int numberRetired)
		{
			Player = player;
			YearRetired = numberRetired;
		}

		public string Player { get; private set; }

		public int YearRetired { get; private set; }
	}
}