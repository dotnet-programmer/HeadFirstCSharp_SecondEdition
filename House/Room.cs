namespace House
{
	internal class Room : Location
	{
		public Room(string name, string decoration) : base(name)
			=> Decoration = decoration;

		public string Decoration { get; }

		public override string Description
			=> base.Description + " Widzisz tutaj " + Decoration;
	}
}