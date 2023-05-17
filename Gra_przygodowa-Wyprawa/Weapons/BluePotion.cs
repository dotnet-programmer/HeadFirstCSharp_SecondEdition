using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa.Weapons
{
	internal class BluePotion : Weapon, IPotion
	{
		public BluePotion(Game game, Point location) : base(game, location)
		{
		}

		public override string Name => "Niebieska mikstura";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			game.IncreasePlayerHealth(5, random);
			used = true;
		}

		private bool used;
		public bool Used => used;
	}
}