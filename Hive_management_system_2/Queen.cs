namespace Hive_management_system_2
{
	internal class Queen : Bee
	{
		private readonly Worker[] _workers;

		public Queen(Worker[] workers) : base(275)
			=> _workers = workers;

		public int ShiftNumber { get; private set; }

		public bool AssignWork(string job, int shifts)
		{
			foreach (var item in _workers)
			{
				if (item.DoThisJob(job, shifts))
				{
					return true;
				}
			}

			return false;
		}

		public override double GetHoneyConsumption()
		{
			double honeyConsumption = 0;
			double maxConsupmtion = 0;
			int workWorkers = 0;

			foreach (var item in _workers)
			{
				if (item.GetHoneyConsumption() > maxConsupmtion)
				{
					maxConsupmtion = item.GetHoneyConsumption();
				}

				if (item.ShiftLefts > 0)
				{
					workWorkers++;
				}
			}

			honeyConsumption += maxConsupmtion;

			if (workWorkers >= 3)
			{
				honeyConsumption += 30;
			}
			else
			{
				honeyConsumption += 20;
			}

			return honeyConsumption;
		}

		public string WorkTheNextShift()
		{
			double totalConsumption = 0;
			foreach (var item in _workers)
			{
				totalConsumption += item.GetHoneyConsumption();
			}

			totalConsumption += GetHoneyConsumption();

			ShiftNumber++;
			string report = "Raport zmiany numer " + ShiftNumber + "\r\n";

			for (int i = 0; i < _workers.Length; i++)
			{
				if (_workers[i].WorkOneShift())
				{
					report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie\r\n";
				}

				if (string.IsNullOrEmpty(_workers[i].CurrentJob))
				{
					report += "Robotnica numer " + (i + 1) + " nie pracuje\r\n";
				}
				else
				{
					if (_workers[i].ShiftLefts > 0)
					{
						report += "Robotnica numer " + (i + 1) + " robi '" + _workers[i].CurrentJob + "' jeszcze przez " + _workers[i].ShiftLefts + " zmiany\r\n";
					}
					else
					{
						report += "Robotnica numer " + (i + 1) + " zakończy '" + _workers[i].CurrentJob + "' po tej zmianie\r\n";
					}
				}
			}

			report += "Całkowite spożycie miodu: " + totalConsumption + " jednostek";

			return report;
		}
	}
}