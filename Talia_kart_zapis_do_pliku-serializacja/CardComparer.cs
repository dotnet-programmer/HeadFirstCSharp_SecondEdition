using System;
using System.Collections.Generic;

namespace Talia_kart_zapis_do_pliku_serializacja
{
	[Serializable]
	internal class CardComparer : IComparer<Card>
	{
		public int Compare(Card x, Card y) => x.Value > y.Value ? 1 : x.Value < y.Value ? -1 : x.Suit > y.Suit ? 1 : x.Suit < y.Suit ? -1 : 0;
	}
}