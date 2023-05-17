namespace Dom
{
	internal interface IHasExteriorDoor
	{
		string DoorDescription { get; }
		Location DoorLocation { get; set; }
	}
}