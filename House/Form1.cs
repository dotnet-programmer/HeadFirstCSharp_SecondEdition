using System;
using System.Windows.Forms;

namespace House
{
	public partial class Form1 : Form
	{
		private RoomWithDoor _livingRoom;
		private RoomWithDoor _kitchen;
		private Room _diningRoom;
		private OutsideWithDoor _frontYard;
		private OutsideWithDoor _backYard;
		private Outside _garden;

		public Form1()
		{
			InitializeComponent();
			CreateObjects();
			MoveToANewLocation(_livingRoom);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			_livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką");
			_kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi");
			_diningRoom = new Room("Jadalnia", "kryształowy żyrandol");

			_frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
			_backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
			_garden = new Outside("Ogród", false);

			_frontYard.DoorLocation = _livingRoom;
			_livingRoom.DoorLocation = _frontYard;
			_kitchen.DoorLocation = _backYard;
			_backYard.DoorLocation = _kitchen;

			_livingRoom.Exits = new Location[] { _diningRoom };
			_diningRoom.Exits = new Location[] { _livingRoom, _kitchen };
			_kitchen.Exits = new Location[] { _diningRoom };

			_frontYard.Exits = new Location[] { _backYard, _garden };
			_backYard.Exits = new Location[] { _frontYard, _garden };
			_garden.Exits = new Location[] { _frontYard, _backYard };
		}

		private void MoveToANewLocation(Location location)
		{
			CurrentLocation = location;
			exits.Items.Clear();
			foreach (var item in location.Exits)
			{
				exits.Items.Add(item.Name);
			}

			exits.SelectedIndex = 0;
			description.Text = location.Description;
			goThroughTheDoor.Visible = location is IHasExteriorDoor;
		}

		private void goHere_Click(object sender, EventArgs e)
			=> MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);

		private void goThroughTheDoor_Click(object sender, EventArgs e)
		{
			//if (CurrentLocation is RoomWithDoor)
			//	MoveToANewLocation((CurrentLocation as RoomWithDoor).DoorLocation);
			//else if (CurrentLocation is OutsideWithDoor)
			//	MoveToANewLocation((CurrentLocation as OutsideWithDoor).DoorLocation);
			IHasExteriorDoor hasDoor = CurrentLocation as IHasExteriorDoor;
			MoveToANewLocation(hasDoor.DoorLocation);
		}
	}
}