using System;

namespace Birds
{
	internal class Duck : Bird, IComparable<Duck>
	{
		public int Size { get; set; }

		public KindOfDuck Kind { get; set; }

		public string DuckInfo
			=> Kind.ToString() + " - " + Size.ToString();

		public int CompareTo(Duck other)
			=> Size > other.Size ? 1 : Size < other.Size ? -1 : 0;

		public override string ToString()
			=> Size + "-centymetrowa kaczka " + Kind.ToString();
	}

	public enum KindOfDuck
	{
		Mallard,
		Muscovy,
		Decoy
	}
}