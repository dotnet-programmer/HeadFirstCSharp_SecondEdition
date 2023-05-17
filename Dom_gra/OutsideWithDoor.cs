namespace Dom_gra
{
	internal class OutsideWithDoor : Outside, IHasExteriorDoor
	{
		public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot) => DoorDescription = doorDescription;

		public string DoorDescription { get; }

		private Location doorLocation;
		public Location DoorLocation { get => doorLocation; set => doorLocation = value; }

		public override string Description => base.Description + "\r\nWidzisz teraz: " + DoorDescription + ".";
	}
}