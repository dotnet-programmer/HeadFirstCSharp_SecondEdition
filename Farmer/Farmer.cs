namespace Farmer
{
	internal class Farmer
	{
		//public int BagsOfFeed;
		public int BagsOfFeed { get; private set; }

		//public const int FeedMultiplier = 30;
		private readonly int feedMultiplier;

		public int FeedMultiplier => feedMultiplier;

		private int numberOfCows;
		public int NumberOfCows
		{
			get => numberOfCows;
			set
			{
				numberOfCows = value;
				BagsOfFeed = numberOfCows * FeedMultiplier;
			}
		}

		public Farmer(int numberOfCows, int feedMultiplier)
		{
			this.feedMultiplier = feedMultiplier;
			NumberOfCows = numberOfCows;
		}
	}
}