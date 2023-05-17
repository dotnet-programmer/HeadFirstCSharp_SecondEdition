using System;

namespace Dom_gra
{
	internal class Opponent
	{
		public Opponent(Location startingLocation)
		{
			myLocation = startingLocation;
			random = new Random();
		}

		private Location myLocation;
		private readonly Random random;

		public void Move()
		{
			if (myLocation is IHasExteriorDoor)
			{
				if (random.Next(2) == 1)
				{
					myLocation = (myLocation as IHasExteriorDoor).DoorLocation;
				}
			}

			bool hidden = false;
			while (!hidden)
			{
				int rand = random.Next(myLocation.Exits.Length);
				myLocation = myLocation.Exits[rand];

				if (myLocation is IHidingPlace)
				{
					hidden = true;
				}
			}
		}

		public bool Check(Location location) => myLocation == location;
	}
}