namespace House
{
	public abstract class Location
	{
		public Location[] Exits;

		public Location(string name)
			=> Name = name;

		public string Name { get; }

		public virtual string Description
		{
			get
			{
				string description = "Stoisz w: " + Name + ". Widzisz wyjścia do następujących lokalizacji:";
				for (int i = 0; i < Exits.Length; i++)
				{
					description += " " + Exits[i].Name;
					if (i != Exits.Length - 1)
					{
						description += ", ";
					}
				}
				description += ".";
				return description;
			}
		}
	}
}