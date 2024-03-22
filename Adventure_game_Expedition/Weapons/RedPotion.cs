using System;
using System.Drawing;

namespace Adventure_game_Expedition.Weapons
{
	internal class RedPotion : Weapon, IPotion
	{
		private bool used;

		public RedPotion(Game game, Point location) : base(game, location)
		{
		}

		public override string Name 
			=> "Czerwona mikstura";

		public bool Used 
			=> used;

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			game.IncreasePlayerHealth(10, random);
			used = true;
		}
	}
}