using System;
using System.Drawing;

namespace Adventure_game_Expedition.Weapons
{
	internal class BluePotion : Weapon, IPotion
	{
		private bool _used;

		public BluePotion(Game game, Point location) : base(game, location)
		{
		}

		public bool Used 
			=> _used;


		public override string Name 
			=> "Niebieska mikstura";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			game.IncreasePlayerHealth(5, random);
			_used = true;
		}

	}
}