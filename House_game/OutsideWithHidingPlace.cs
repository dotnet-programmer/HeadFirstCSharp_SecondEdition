namespace House_game
{
	internal class OutsideWithHidingPlace : Outside, IHidingPlace
	{
		public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot) 
			=> HidingPlaceName = hidingPlaceName;

		public string HidingPlaceName { get; }

		public override string Description 
			=> base.Description + "\r\nKtoś może ukrywać się tutaj: " + HidingPlaceName + ".";
	}
}