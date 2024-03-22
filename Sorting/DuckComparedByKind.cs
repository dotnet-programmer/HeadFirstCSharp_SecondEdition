using System.Collections.Generic;

namespace Sorting
{
	internal class DuckComparedByKind : IComparer<Duck>
	{
		public int Compare(Duck x, Duck y) 
			=> x.Kind < y.Kind ? -1 : x.Kind > y.Kind ? 1 : 0;
	}
}