using System;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa.Weapons
{
	internal class RedPotion : Weapon, IPotion
	{
		public RedPotion(Game game, Point location) : base(game, location)
		{
		}

		public override string Name => "Czerwona mikstura";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			game.IncreasePlayerHealth(10, random);
			used = true;
		}

		private bool used;
		public bool Used => used;
	}
}