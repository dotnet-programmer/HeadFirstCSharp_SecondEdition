namespace House
{
	internal class RoomWithDoor : Room, IHasExteriorDoor
	{
		private Location _doorLocation;

		public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
			=> DoorDescription = doorDescription;

		public string DoorDescription { get; }

		public Location DoorLocation { get => _doorLocation; set => _doorLocation = value; }
	}
}