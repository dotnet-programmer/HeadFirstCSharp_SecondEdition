﻿using System;

namespace Events_1
{
	internal class BallEventArgs : EventArgs
	{
		public BallEventArgs(int Trajectory, int Distance)
		{
			this.Trajectory = Trajectory;
			this.Distance = Distance;
		}

		public int Trajectory { get; private set; }

		public int Distance { get; private set; }
	}
}