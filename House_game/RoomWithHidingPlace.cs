namespace House_game
{
	internal class RoomWithHidingPlace : Room, IHidingPlace
	{
		public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
			=> HidingPlaceName = hidingPlaceName;

		public string HidingPlaceName { get; }

		public override string Description
			=> base.Description + "\r\nKtoś może ukrywać się tutaj: " + HidingPlaceName + ".";
	}
}