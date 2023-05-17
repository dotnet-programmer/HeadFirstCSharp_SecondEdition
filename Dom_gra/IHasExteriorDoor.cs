namespace Dom_gra
{
	internal interface IHasExteriorDoor
	{
		string DoorDescription { get; }
		Location DoorLocation { get; set; }
	}
}