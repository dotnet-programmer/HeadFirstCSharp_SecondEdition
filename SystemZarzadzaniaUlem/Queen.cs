namespace SystemZarzadzaniaUlem
{
	internal class Queen
	{
		private readonly Worker[] workers;
		public int ShiftNumber { get; private set; }

		public Queen(Worker[] workers) => this.workers = workers;

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

		public string WorkTheNextShift()
		{
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
			return report;
		}
	}
}