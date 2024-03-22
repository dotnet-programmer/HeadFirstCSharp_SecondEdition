namespace Events_1
{
	internal class Bat
	{
		private readonly BatCallback _hitBallCallback;

		public Bat(BatCallback callbackDelegate) 
			=> _hitBallCallback = new BatCallback(callbackDelegate);

		public void HitTheBall(BallEventArgs e) 
			=> _hitBallCallback?.Invoke(e);
	}
}