using System;

namespace Zdarzenia_1
{
	internal class Fan
	{
		public Fan(Ball ball) => ball.BallInPlay += Ball_BallInPlay;

		private void Ball_BallInPlay(object sender, EventArgs e)
		{
			if (e is BallEventArgs)
			{
				BallEventArgs ballEventArgs = e as BallEventArgs;
				if ((ballEventArgs.Distance > 120) && (ballEventArgs.Trajectory > 30))
				{
					CatchBall();
				}
				else
				{
					Sing();
				}
			}
		}

		private void CatchBall() => Console.WriteLine("Fan: Home run! Ide po piłkę!");

		private void Sing() => Console.WriteLine("Fan: Jeee! Do boju!");
	}
}