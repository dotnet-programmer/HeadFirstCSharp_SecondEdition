namespace House_game
{
	internal interface IHasExteriorDoor
	{
		string DoorDescription { get; }
		Location DoorLocation { get; set; }
	}
}