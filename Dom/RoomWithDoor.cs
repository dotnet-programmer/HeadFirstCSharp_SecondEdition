namespace Dom
{
	internal class RoomWithDoor : Room, IHasExteriorDoor
	{
		public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration) => DoorDescription = doorDescription;

		public string DoorDescription { get; }

		private Location doorLocation;
		public Location DoorLocation { get => doorLocation; set => doorLocation = value; }
	}
}