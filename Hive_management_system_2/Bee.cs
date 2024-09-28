namespace Hive_management_system_2
{
	internal class Bee
	{
		private readonly int _beeWeight;

		public Bee(int beeWeight)
			=> _beeWeight = beeWeight;

		public virtual int ShiftLefts
			=> 0;

		public virtual double GetHoneyConsumption()
		{
			double honeyConsumption = ShiftLefts > 0 ? ShiftLefts + 9 : 7.5;
			if (_beeWeight > 150)
			{
				honeyConsumption *= 1.35;
			}

			return honeyConsumption;
		}
	}
}