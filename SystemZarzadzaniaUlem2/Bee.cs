namespace SystemZarzadzaniaUlem2
{
	internal class Bee
	{
		public Bee(int beeWeight) => this.beeWeight = beeWeight;

		public virtual int ShiftLefts => 0;

		private readonly int beeWeight;

		public virtual double GetHoneyConsumption()
		{
			double honeyConsumption = ShiftLefts > 0 ? ShiftLefts + 9 : 7.5;
			if (beeWeight > 150)
			{
				honeyConsumption *= 1.35;
			}

			return honeyConsumption;
		}
	}
}