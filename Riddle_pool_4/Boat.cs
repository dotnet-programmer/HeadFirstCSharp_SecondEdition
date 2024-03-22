namespace Riddle_pool_4
{
	// Boat
	internal class Boat
	{
		// length
		private int length;

		// public / setLength / int len
		public void setLength(int len)
			=> length = len;

		// return length
		public int getLength()
			=> length;

		// virtual string
		public virtual string move()
			// dryfuje
			=> "  dryfuje  ";
	}
}