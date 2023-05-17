using System;

namespace Zdarzenia_1
{
	internal class BallEventArgs : EventArgs
	{
		public int Trajectory { get; private set; }
		public int Distance { get; private set; }

		public BallEventArgs(int Trajectory, int Distance)
		{
			this.Trajectory = Trajectory;
			this.Distance = Distance;
		}
	}
}