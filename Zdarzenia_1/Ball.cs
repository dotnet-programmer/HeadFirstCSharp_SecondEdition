using System;

namespace Zdarzenia_1
{
	internal class Ball
	{
		public event EventHandler<BallEventArgs> BallInPlay;

		protected void OnBallInPlay(BallEventArgs e)
		{
			EventHandler<BallEventArgs> ballInPlay = BallInPlay;
			if (BallInPlay != null)
			{
				BallInPlay(this, e);
			}
		}

		public Bat GetNewBat() => new Bat(new BatCallback(OnBallInPlay));
	}
}