using System;
using System.Drawing;
using System.Windows.Forms;

namespace House_game
{
	public partial class Form1 : Form
	{
		private Room _stairs;
		private RoomWithDoor _livingRoom;
		private RoomWithDoor _kitchen;
		private RoomWithHidingPlace _diningRoom;
		private RoomWithHidingPlace _hallway;
		private RoomWithHidingPlace _bathroom;
		private RoomWithHidingPlace _masterBedroom;
		private RoomWithHidingPlace _secondBedroom;
		private OutsideWithDoor _frontYard;
		private OutsideWithDoor _backYard;
		private OutsideWithHidingPlace _garden;
		private OutsideWithHidingPlace _driveway;
		private readonly Opponent _opponent;
		private int _moves;

		public Form1()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			InitializeComponent();
			CreateObjects();
			_opponent = new Opponent(_frontYard);
			ResetGame(false);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			_stairs = new Room("Schody", "drewniana poręcz");
			_livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie ściennej", "dębowe drzwi z mosiężną klamką");
			_kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "w szafce", "rozsuwane drzwi");
			_diningRoom = new RoomWithHidingPlace("Jadalnia", "kryształowy żyrandol", "w wysokiej szafie");
			_hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "w szafie ściennej");
			_bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
			_masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
			_secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "małe łóżko", "pod łóżkiem");

			_frontYard = new OutsideWithDoor("Podwórko przed domem", false, "ciężkie dębowe drzwi");
			_backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
			_garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
			_driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

			_livingRoom.Exits = new Location[] { _diningRoom, _stairs };
			_diningRoom.Exits = new Location[] { _livingRoom, _kitchen };
			_kitchen.Exits = new Location[] { _diningRoom };
			_stairs.Exits = new Location[] { _livingRoom, _hallway };
			_hallway.Exits = new Location[] { _stairs, _bathroom, _masterBedroom, _secondBedroom };
			_bathroom.Exits = new Location[] { _hallway };
			_masterBedroom.Exits = new Location[] { _hallway };
			_secondBedroom.Exits = new Location[] { _hallway };

			_frontYard.Exits = new Location[] { _backYard, _garden, _driveway };
			_backYard.Exits = new Location[] { _frontYard, _garden, _driveway };
			_garden.Exits = new Location[] { _frontYard, _backYard };
			_driveway.Exits = new Location[] { _backYard, _frontYard };

			_frontYard.DoorLocation = _livingRoom;
			_livingRoom.DoorLocation = _frontYard;

			_kitchen.DoorLocation = _backYard;
			_backYard.DoorLocation = _kitchen;
		}

		private void MoveToANewLocation(Location location)
		{
			_moves++;
			CurrentLocation = location;
			RedrawForm();
		}

		private void goHere_Click(object sender, EventArgs e)
			=> MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);

		private void goThroughTheDoor_Click(object sender, EventArgs e)
		{
			IHasExteriorDoor hasDoor = CurrentLocation as IHasExteriorDoor;
			MoveToANewLocation(hasDoor.DoorLocation);
		}

		private void hide_Click(object sender, EventArgs e)
		{
			hide.Visible = false;

			for (int i = 1; i < 11; i++)
			{
				_opponent.Move();
				description.Text = i + "... ";
				description.Refresh();
				//Application.DoEvents();
				System.Threading.Thread.Sleep(300);
			}

			description.Text = "Gotowy czy nie - nadchodzę!";
			Application.DoEvents();
			System.Threading.Thread.Sleep(800);

			goHere.Visible = exits.Visible = true;
			MoveToANewLocation(_livingRoom);
		}

		private void RedrawForm()
		{
			exits.Items.Clear();
			foreach (var item in CurrentLocation.Exits)
			{
				exits.Items.Add(item.Name);
			}

			exits.SelectedIndex = 0;

			description.Text = CurrentLocation.Description + "\r\n\r\nRuch numer " + _moves + "";

			if (CurrentLocation is IHidingPlace)
			{
				check.Text = "Sprawdź " + (CurrentLocation as IHidingPlace).HidingPlaceName;
				check.Visible = true;
			}
			else
			{
				check.Visible = false;
			}

			goThroughTheDoor.Visible = CurrentLocation is IHasExteriorDoor;

			picture.Image = CurrentLocation.Name == "Salon"
				? Properties.Resources.salon
				: CurrentLocation.Name == "Kuchnia"
					? Properties.Resources.kuchnia
					: CurrentLocation.Name == "Jadalnia" ? Properties.Resources.jadalnia : (Image)null;
		}

		private void ResetGame(bool displayMessage)
		{
			if (displayMessage)
			{
				MessageBox.Show("Odnalazłeś mnie w " + _moves + " ruchach!");
				description.Text = "Znalazłeś przeciwnika w " + _moves + " ruchach! Ukrywał się " + (CurrentLocation as IHidingPlace).HidingPlaceName + ".";
			}

			_moves = 0;
			hide.Visible = true;
			goHere.Visible = check.Visible = goThroughTheDoor.Visible = exits.Visible = false;
			picture.Image = null;
		}

		private void check_Click(object sender, EventArgs e)
		{
			_moves++;
			if (_opponent.Check(CurrentLocation))
			{
				ResetGame(true);
			}
			else
			{
				description.Text = "Nikogo tu nie ma!";
				description.Refresh();
				System.Threading.Thread.Sleep(1000);
				RedrawForm();
			}
		}

		private void DoorButtonRightClick(object sender, EventArgs e)
		{
			if (CurrentLocation.Name == "Salon")
			{
				MoveToANewLocation(_diningRoom);
			}
		}
	}
}