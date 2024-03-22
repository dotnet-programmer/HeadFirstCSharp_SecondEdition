using System;

namespace Events_1
{
	internal class Pitcher
	{
		public Pitcher(Ball ball) 
			=> ball.BallInPlay += Ball_BallInPlay;

		private void Ball_BallInPlay(object sender, EventArgs e)
		{
			if (e is BallEventArgs)
			{
				BallEventArgs ballEventArgs = e as BallEventArgs;
				if ((ballEventArgs.Distance < 29) && (ballEventArgs.Trajectory < 60))
				{
					CatchBall();
				}
				else
				{
					CoverFirstBase();
				}
			}
		}

		private void CatchBall() 
			=> Console.WriteLine("Miotacz: Złapałem piłkę.");

		private void CoverFirstBase() 
			=> Console.WriteLine("Miotacz: Pokryłem pierwszą baze.");
	}
}