namespace Dom2
{
	public class Door
	{
		public Door(Location location1, Location location2, string doorDescription, bool isOutside)
		{
			locations = new Location[2] { location1, location2 };
			DoorDescription = doorDescription;
			IsOutside = isOutside;
		}

		private readonly Location[] locations;

		public string DoorDescription { get; }

		public bool IsOutside { get; }
	}
}