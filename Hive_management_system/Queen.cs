namespace Hive_management_system
{
	internal class Queen
	{
		private readonly Worker[] _workers;

		public Queen(Worker[] workers)
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

		public string WorkTheNextShift()
		{
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
			return report;
		}
	}
}