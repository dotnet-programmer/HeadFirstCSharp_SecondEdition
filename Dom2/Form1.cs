using System.Windows.Forms;

namespace Dom2
{
	public partial class Form1 : Form
	{
		private Room livingRoom;
		private Room kitchen;
		private Room diningRoom;
		private Outside frontYard;
		private Outside backYard;
		private Outside garden;
		private Door livingRoomDiningRoom;
		private Door diningRoomKitchen;

		public Form1()
		{
			InitializeComponent();
			CreateObjects();
			MoveToANewLocation(livingRoom);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			livingRoomDiningRoom = new Door(livingRoom, diningRoom, "drewniane drzwi ze szkłem", false);
			diningRoomKitchen = new Door(diningRoom, kitchen, "drzwi przesuwne", false);

			livingRoom = new Room("Salon", "antyczny dywan");
			kitchen = new Room("Kuchnia", "nierdzewne stalowe sztućce");
			diningRoom = new Room("Jadalnia", "kryształowy żyrandol");

			frontYard = new Outside("Podwórko przed domem");
			backYard = new Outside("Podwórko za domem");
			garden = new Outside("Ogród");

			livingRoom.Door = livingRoomDiningRoom;
			diningRoom.Door = livingRoomDiningRoom;
		}

		private void MoveToANewLocation(Location location)
		{
			CurrentLocation = location;
			description.Text = location.Description;
		}
	}
}