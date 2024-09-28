using System;

namespace House_2
{
	internal class Outside : Location
	{
		private readonly Random random;

		private readonly string[] weatherCondition
			= { "świeci słońce", "pochmurno", "wieje", "burza", "pada deszcz", "pada śnieg", "mróz" };

		public Outside(string name) : base(name)
			=> random = new Random();

		public string WeatherCondition
			=> weatherCondition[random.Next(0, weatherCondition.Length)];
	}
}