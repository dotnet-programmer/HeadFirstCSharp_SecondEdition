using System;

namespace Restaurant
{
	internal class MenuMaker
	{
		public Random Randomizer;
		public string[] Meats = { "Pieczona włowina", "Salami", "Indyk", "Szynka", "Karkówka" };
		public string[] Condiments = { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
		public string[] Breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

		public string GetMenuItem()
		{
			string randomMeat = Meats[Randomizer.Next(Meats.Length)];
			string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
			string randomBread = Breads[Randomizer.Next(Breads.Length)];
			return randomMeat + ", " + randomCondiment + ", " + randomBread;
		}
	}
}