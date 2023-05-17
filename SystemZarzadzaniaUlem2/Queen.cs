namespace SystemZarzadzaniaUlem2
{
	internal class Queen : Bee
	{
		public Queen(Worker[] workers) : base(275) => this.workers = workers;

		private readonly Worker[] workers;
		public int ShiftNumber { get; private set; }

		public bool AssignWork(string job, int shifts)
		{
			foreach (var item in workers)
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

			foreach (var item in workers)
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
			foreach (var item in workers)
			{
				totalConsumption += item.GetHoneyConsumption();
			}

			totalConsumption += GetHoneyConsumption();

			ShiftNumber++;
			string report = "Raport zmiany numer " + ShiftNumber + "\r\n";

			for (int i = 0; i < workers.Length; i++)
			{
				if (workers[i].WorkOneShift())
				{
					report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie\r\n";
				}

				if (string.IsNullOrEmpty(workers[i].CurrentJob))
				{
					report += "Robotnica numer " + (i + 1) + " nie pracuje\r\n";
				}
				else
				{
					if (workers[i].ShiftLefts > 0)
					{
						report += "Robotnica numer " + (i + 1) + " robi '" + workers[i].CurrentJob + "' jeszcze przez " + workers[i].ShiftLefts + " zmiany\r\n";
					}
					else
					{
						report += "Robotnica numer " + (i + 1) + " zakończy '" + workers[i].CurrentJob + "' po tej zmianie\r\n";
					}
				}
			}

			report += "Całkowite spożycie miodu: " + totalConsumption + " jednostek";

			return report;
		}
	}
}