using System.Windows.Forms;

namespace House_2
{
	public partial class Form1 : Form
	{
		private Room _livingRoom;
		private Room _kitchen;
		private Room _diningRoom;
		private Outside _frontYard;
		private Outside _backYard;
		private Outside _garden;
		private Door _livingRoomDiningRoom;
		private Door _diningRoomKitchen;

		public Form1()
		{
			InitializeComponent();
			CreateObjects();
			MoveToANewLocation(_livingRoom);
		}

		public Location CurrentLocation { get; set; }

		private void CreateObjects()
		{
			_livingRoomDiningRoom = new Door(_livingRoom, _diningRoom, "drewniane drzwi ze szkłem", false);
			_diningRoomKitchen = new Door(_diningRoom, _kitchen, "drzwi przesuwne", false);

			_livingRoom = new Room("Salon", "antyczny dywan");
			_kitchen = new Room("Kuchnia", "nierdzewne stalowe sztućce");
			_diningRoom = new Room("Jadalnia", "kryształowy żyrandol");

			_frontYard = new Outside("Podwórko przed domem");
			_backYard = new Outside("Podwórko za domem");
			_garden = new Outside("Ogród");

			_livingRoom.Door = _livingRoomDiningRoom;
			_diningRoom.Door = _livingRoomDiningRoom;
		}

		private void MoveToANewLocation(Location location)
		{
			CurrentLocation = location;
			description.Text = location.Description;
		}
	}
}