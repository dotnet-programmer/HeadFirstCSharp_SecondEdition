namespace Zdarzenia_1
{
	internal class Bat
	{
		private readonly BatCallback hitBallCallback;

		public Bat(BatCallback callbackDelegate) => this.hitBallCallback = new BatCallback(callbackDelegate);

		public void HitTheBall(BallEventArgs e)
		{
			if (hitBallCallback != null)
			{
				hitBallCallback(e);
			}
		}
	}
}