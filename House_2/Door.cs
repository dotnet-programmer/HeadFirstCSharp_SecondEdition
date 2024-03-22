namespace House_2
{
	public class Door
	{
		private readonly Location[] _locations;

		public Door(Location location1, Location location2, string doorDescription, bool isOutside)
		{
			_locations = new Location[2] { location1, location2 };
			DoorDescription = doorDescription;
			IsOutside = isOutside;
		}

		public string DoorDescription { get; }

		public bool IsOutside { get; }
	}
}