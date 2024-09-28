namespace House
{
	internal class Outside : Location
	{
		public Outside(string name, bool hot) : base(name)
			=> Hot = hot;

		public bool Hot { get; }

		public override string Description
		{
			get
			{
				string description = base.Description;
				if (Hot)
				{
					description += " Tutaj jest bardzo gorąco.";
				}

				return description;
			}
		}
	}
}