namespace Farmer
{
	internal class Farmer
	{
		private readonly int _feedMultiplier;
		private int _numberOfCows;

		public Farmer(int numberOfCows, int feedMultiplier)
		{
			_feedMultiplier = feedMultiplier;
			NumberOfCows = numberOfCows;
		}

		public int BagsOfFeed { get; private set; }

		public int FeedMultiplier
			=> _feedMultiplier;

		public int NumberOfCows
		{
			get => _numberOfCows;
			set
			{
				_numberOfCows = value;
				BagsOfFeed = _numberOfCows * FeedMultiplier;
			}
		}
	}
}