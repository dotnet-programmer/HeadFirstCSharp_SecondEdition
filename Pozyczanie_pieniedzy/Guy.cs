﻿using System.Windows.Forms;

namespace Pozyczanie_pieniedzy
{
	public class Guy
	{
		public string Name;
		public int Cash;

		public int GiveCash(int amount)
		{
			if (amount <= Cash && amount > 0)
			{
				Cash -= amount;
				return amount;
			}
			else
			{
				MessageBox.Show("Nie mam tylu pieniędzy " + amount, Name + " powiedział...");
				return 0;
			}
		}

		public int RecieveCash(int amount)
		{
			if (amount > 0)
			{
				Cash += amount;
				return amount;
			}
			else
			{
				MessageBox.Show(amount + " to nie jest ilość pieniędzy, którą mogę wziąć ", Name + " pwiedział...");
				return 0;
			}
		}
	}
}