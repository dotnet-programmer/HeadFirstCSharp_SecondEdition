using System;

namespace Interface_1
{
	internal class Bee : IStingPatrol
	{
		int IStingPatrol.AlertLevel
			=> throw new NotImplementedException();

		int IStingPatrol.StingLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		bool IStingPatrol.LookForEnemies()
			=> throw new NotImplementedException();

		int IStingPatrol.SharpenStinger(int length)
			=> throw new NotImplementedException();
	}
}