namespace House_game
{
	internal class OutsideWithDoor : Outside, IHasExteriorDoor
	{
		private Location _doorLocation;

		public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
			=> DoorDescription = doorDescription;

		public string DoorDescription { get; }

		public Location DoorLocation { get => _doorLocation; set => _doorLocation = value; }

		public override string Description
			=> base.Description + "\r\nWidzisz teraz: " + DoorDescription + ".";
	}
}