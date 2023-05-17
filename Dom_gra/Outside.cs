namespace Dom_gra
{
	internal class Outside : Location
	{
		public Outside(string name, bool hot) : base(name) => Hot = hot;

		public bool Hot { get; }

		public override string Description
		{
			get
			{
				string description = base.Description;
				if (Hot)
				{
					description += "\r\nTutaj jest bardzo gorąco.";
				}

				return description;
			}
		}
	}
}