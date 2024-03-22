namespace Interface_1
{
	internal interface IStingPatrol
	{
		int AlertLevel { get; }
		int StingLength { get; set; }

		bool LookForEnemies();

		int SharpenStinger(int length);
	}
}