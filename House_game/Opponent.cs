using System;

namespace House_game
{
	internal class Opponent
	{
		private Location _myLocation;
		private readonly Random _random;

		public Opponent(Location startingLocation)
		{
			_myLocation = startingLocation;
			_random = new Random();
		}

		public void Move()
		{
			if (_myLocation is IHasExteriorDoor)
			{
				if (_random.Next(2) == 1)
				{
					_myLocation = (_myLocation as IHasExteriorDoor).DoorLocation;
				}
			}

			bool hidden = false;
			while (!hidden)
			{
				int rand = _random.Next(_myLocation.Exits.Length);
				_myLocation = _myLocation.Exits[rand];

				if (_myLocation is IHidingPlace)
				{
					hidden = true;
				}
			}
		}

		public bool Check(Location location)
			=> _myLocation == location;
	}
}