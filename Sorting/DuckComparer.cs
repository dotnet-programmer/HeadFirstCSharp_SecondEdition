using System.Collections.Generic;

namespace Sorting
{
	public enum SortCriteria
	{
		SizeThenKind,
		KindThenSize
	}

	internal class DuckComparer : IComparer<Duck>
	{
		public SortCriteria SortBy = SortCriteria.SizeThenKind;

		public int Compare(Duck x, Duck y)
			=> SortBy == SortCriteria.SizeThenKind
				? x.Size < y.Size ? -1 : x.Size > y.Size ? 1 : x.Kind < y.Kind ? -1 : x.Kind > y.Kind ? 1 : 0
				: x.Kind < y.Kind ? -1 : x.Kind > y.Kind ? 1 : x.Size < y.Size ? -1 : x.Size > y.Size ? 1 : 0;
	}
}