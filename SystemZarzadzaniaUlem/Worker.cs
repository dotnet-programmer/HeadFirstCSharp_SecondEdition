using System;

namespace SystemZarzadzaniaUlem
{
	internal class Worker
	{
		public string CurrentJob { get; private set; }
		public int ShiftLefts => shiftsToWork - shiftsWorked;

		private readonly string[] jobsICanDo;
		private int shiftsToWork;
		private int shiftsWorked;

		public Worker(string[] jobs) => jobsICanDo = jobs;

		public bool DoThisJob(string job, int shifts)
		{
			if (!String.IsNullOrEmpty(CurrentJob))
			{
				return false;
			}

			foreach (var item in jobsICanDo)
			{
				if (item == job)
				{
					shiftsToWork = shifts;
					CurrentJob = job;
					shiftsWorked = 0;
					return true;
				}
			}

			return false;
		}

		public bool WorkOneShift()
		{
			if (String.IsNullOrEmpty(CurrentJob))
			{
				return false;
			}

			shiftsWorked++;
			if (shiftsWorked > shiftsToWork)
			{
				shiftsWorked = 0;
				shiftsToWork = 0;
				CurrentJob = "";
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}