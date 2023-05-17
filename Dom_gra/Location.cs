namespace Dom_gra
{
	public abstract class Location
	{
		public Location(string name) => Name = name;

		public string Name { get; }

		public Location[] Exits;

		public virtual string Description
		{
			get
			{
				string description = "Stoisz w: " + Name + ".\r\nWidzisz wyjścia do następujących lokalizacji: ";
				for (int i = 0; i < Exits.Length; i++)
				{
					description += Exits[i].Name;
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