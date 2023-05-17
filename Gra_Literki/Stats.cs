namespace Gra_Literki
{
	internal class Stats
	{
		public int Total = 0;
		public int Missed = 0;
		public int Correct = 0;
		public int Accuracy = 0;

		public void Update(bool correctKey)
		{
			Total++;

			if (!correctKey)
			{
				Missed++;
			}
			else
			{
				Correct++;
			}

			Accuracy = 100 * Correct / (Missed + Correct);
		}
	}
}