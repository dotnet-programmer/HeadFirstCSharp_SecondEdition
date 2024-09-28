using System.Collections.Generic;

namespace House_2
{
	public abstract class Location
	{
		private readonly List<Door> _doors = new List<Door>();

		public Location(string name)
			=> Name = name;

		public Door Door
		{
			set => _doors.Add(value);
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