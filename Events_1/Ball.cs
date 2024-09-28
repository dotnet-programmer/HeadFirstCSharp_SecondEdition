using System;

namespace Events_1
{
	internal class Ball
	{
		public event EventHandler<BallEventArgs> BallInPlay;

		protected void OnBallInPlay(BallEventArgs e)
		{
			EventHandler<BallEventArgs> ballInPlay = BallInPlay;
			BallInPlay?.Invoke(this, e);
		}

		public Bat GetNewBat()
			=> new Bat(new BatCallback(OnBallInPlay));
	}
}