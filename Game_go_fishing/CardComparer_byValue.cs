﻿using System.Collections.Generic;

namespace Game_go_fishing
{
	internal class CardComparer_byValue : IComparer<Card>
	{
		public int Compare(Card x, Card y)
		{
			if (x.Value > y.Value)
			{
				return 1;
			}
			else if (x.Value < y.Value)
			{
				return -1;
			}

			return x.Suit > y.Suit ? 1 : x.Suit < y.Suit ? -1 : 0;
		}
	}
}