using System.Collections.Generic;

namespace Sorting
{
	internal class DuckComparerBySize : IComparer<Duck>
	{
		public int Compare(Duck x, Duck y)
			=> x.Size < y.Size ? -1 : x.Size > y.Size ? 1 : 0;
	}
}