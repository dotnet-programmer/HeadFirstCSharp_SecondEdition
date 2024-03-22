using System;

namespace Hive_management_system
{
	internal class Worker
	{
		private readonly string[] _jobsICanDo;
		private int _shiftsToWork;
		private int _shiftsWorked;

		public Worker(string[] jobs)
			=> _jobsICanDo = jobs;

		public int ShiftLefts
			=> _shiftsToWork - _shiftsWorked;

		public string CurrentJob { get; private set; }

		public bool DoThisJob(string job, int shifts)
		{
			if (!String.IsNullOrEmpty(CurrentJob))
			{
				return false;
			}

			foreach (var item in _jobsICanDo)
			{
				if (item == job)
				{
					_shiftsToWork = shifts;
					CurrentJob = job;
					_shiftsWorked = 0;
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

			_shiftsWorked++;
			if (_shiftsWorked > _shiftsToWork)
			{
				_shiftsWorked = 0;
				_shiftsToWork = 0;
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