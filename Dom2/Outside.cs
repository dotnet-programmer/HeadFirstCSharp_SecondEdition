using System;

namespace Dom2
{
	internal class Outside : Location
	{
		public Outside(string name) : base(name) => random = new Random();

		private readonly Random random;

		private readonly string[] weatherCondition = { "świeci słońce", "pochmurno", "wieje", "burza", "pada deszcz", "pada śnieg", "mróz" };
		public string WeatherCondition => weatherCondition[random.Next(0, weatherCondition.Length)];
	}
}