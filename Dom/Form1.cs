using System;
using System.Windows.Forms;

namespace Dom
{
	public partial class Form1 : Form
	{
		private RoomWithDoor livingRoom;
		private RoomWithDoor kitchen;
		private Room diningRoom;
		private OutsideWithDoor frontYard;
		private OutsideWithDoor backYard;
		private Outside garden;

		public Form1()
		{
			InitializeComponent();
			CreateObjects();
			MoveToANewLocation(livingRoom);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką");
			kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi");
			diningRoom = new Room("Jadalnia", "kryształowy żyrandol");

			frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
			backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
			garden = new Outside("Ogród", false);

			frontYard.DoorLocation = livingRoom;
			livingRoom.DoorLocation = frontYard;
			kitchen.DoorLocation = backYard;
			backYard.DoorLocation = kitchen;

			livingRoom.Exits = new Location[] { diningRoom };
			diningRoom.Exits = new Location[] { livingRoom, kitchen };
			kitchen.Exits = new Location[] { diningRoom };

			frontYard.Exits = new Location[] { backYard, garden };
			backYard.Exits = new Location[] { frontYard, garden };
			garden.Exits = new Location[] { frontYard, backYard };
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

		private void goHere_Click(object sender, EventArgs e) => MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);

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