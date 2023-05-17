using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dom_gra
{
	public partial class Form1 : Form
	{
		private Room stairs;
		private RoomWithDoor livingRoom;
		private RoomWithDoor kitchen;
		private RoomWithHidingPlace diningRoom;
		private RoomWithHidingPlace hallway;
		private RoomWithHidingPlace bathroom;
		private RoomWithHidingPlace masterBedroom;
		private RoomWithHidingPlace secondBedroom;
		private OutsideWithDoor frontYard;
		private OutsideWithDoor backYard;
		private OutsideWithHidingPlace garden;
		private OutsideWithHidingPlace driveway;
		private readonly Opponent opponent;
		private int Moves;

		public Form1()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			InitializeComponent();
			CreateObjects();
			opponent = new Opponent(frontYard);
			ResetGame(false);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			stairs = new Room("Schody", "drewniana poręcz");
			livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie ściennej", "dębowe drzwi z mosiężną klamką");
			kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "w szafce", "rozsuwane drzwi");
			diningRoom = new RoomWithHidingPlace("Jadalnia", "kryształowy żyrandol", "w wysokiej szafie");
			hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "w szafie ściennej");
			bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
			masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
			secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "małe łóżko", "pod łóżkiem");

			frontYard = new OutsideWithDoor("Podwórko przed domem", false, "ciężkie dębowe drzwi");
			backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
			garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
			driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

			livingRoom.Exits = new Location[] { diningRoom, stairs };
			diningRoom.Exits = new Location[] { livingRoom, kitchen };
			kitchen.Exits = new Location[] { diningRoom };
			stairs.Exits = new Location[] { livingRoom, hallway };
			hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
			bathroom.Exits = new Location[] { hallway };
			masterBedroom.Exits = new Location[] { hallway };
			secondBedroom.Exits = new Location[] { hallway };

			frontYard.Exits = new Location[] { backYard, garden, driveway };
			backYard.Exits = new Location[] { frontYard, garden, driveway };
			garden.Exits = new Location[] { frontYard, backYard };
			driveway.Exits = new Location[] { backYard, frontYard };

			frontYard.DoorLocation = livingRoom;
			livingRoom.DoorLocation = frontYard;

			kitchen.DoorLocation = backYard;
			backYard.DoorLocation = kitchen;
		}

		private void MoveToANewLocation(Location location)
		{
			Moves++;
			CurrentLocation = location;
			RedrawForm();
		}

		private void goHere_Click(object sender, EventArgs e) => MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);

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
				opponent.Move();
				description.Text = i + "... ";
				description.Refresh();
				//Application.DoEvents();
				System.Threading.Thread.Sleep(300);
			}

			description.Text = "Gotowy czy nie - nadchodzę!";
			Application.DoEvents();
			System.Threading.Thread.Sleep(800);

			goHere.Visible = exits.Visible = true;
			MoveToANewLocation(livingRoom);
		}

		private void RedrawForm()
		{
			exits.Items.Clear();
			foreach (var item in CurrentLocation.Exits)
			{
				exits.Items.Add(item.Name);
			}

			exits.SelectedIndex = 0;

			description.Text = CurrentLocation.Description + "\r\n\r\nRuch numer " + Moves + "";

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
				MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
				description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się " + (CurrentLocation as IHidingPlace).HidingPlaceName + ".";
			}

			Moves = 0;
			hide.Visible = true;
			goHere.Visible = check.Visible = goThroughTheDoor.Visible = exits.Visible = false;
			picture.Image = null;
		}

		private void check_Click(object sender, EventArgs e)
		{
			Moves++;
			if (opponent.Check(CurrentLocation))
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
				MoveToANewLocation(diningRoom);
			}
		}
	}
}