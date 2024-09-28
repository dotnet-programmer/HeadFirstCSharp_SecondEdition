namespace Hive_management_system_2
{
	internal class Worker : Bee
	{
		private readonly string[] _jobsICanDo;
		private int _shiftsToWork;
		private int _shiftsWorked;

		public Worker(string[] jobs, int beeWeight) : base(beeWeight)
			=> _jobsICanDo = jobs;

		public string CurrentJob { get; private set; }

		public override int ShiftLefts
			=> _shiftsToWork - _shiftsWorked;

		public bool DoThisJob(string job, int shifts)
		{
			if (!string.IsNullOrEmpty(CurrentJob))
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
			if (string.IsNullOrEmpty(CurrentJob))
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