using System;

namespace Sorting
{
	internal class DuckWithIComparable : IComparable<DuckWithIComparable>
	{
		public int Size { get; set; }

		public KindOfDuck Kind { get; set; }

		public string DuckInfo
			=> Kind.ToString() + " - " + Size.ToString();

		public int CompareTo(DuckWithIComparable other)
			=> Size > other.Size ? 1 : Size < other.Size ? -1 : 0;
	}
}