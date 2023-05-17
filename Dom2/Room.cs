namespace Dom2
{
	internal class Room : Location
	{
		public Room(string name, string decoration) : base(name) => Decoration = decoration;

		public string Decoration { get; }
	}
}