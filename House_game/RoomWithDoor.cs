namespace House_game
{
	internal class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
	{
		public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription) : base(name, decoration, hidingPlaceName) 
			=> DoorDescription = doorDescription;

		public string DoorDescription { get; }

		public Location DoorLocation { get; set; }
	}
}