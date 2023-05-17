using System.Collections.Generic;

namespace Dom2
{
	public abstract class Location
	{
		public Location(string name) => Name = name;

		private readonly List<Door> doors = new List<Door>();

		//private Door[] doors;
		public Door Door
		{
			set => doors.Add(value);
		}

		public string Name { get; }

		public virtual string Description
		{
			get
			{
				string description = "Stoisz w: " + Name;
				return description;
			}
		}
	}
}