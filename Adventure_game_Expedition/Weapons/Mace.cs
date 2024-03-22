using System;
using System.Drawing;

namespace Adventure_game_Expedition.Weapons
{
	internal class Mace : Weapon
	{
		public Mace(Game game, Point location) : base(game, location)
		{
		}

		public override string Name 
			=> "Buława";

		public override void Attack(Direction direction, Random random, Stats stats)
		{
			for (int i = 0; i < 4; i++)
			{
				DamageEnemy((Direction)i, 20, 6, random, stats);
			}
		}
	}
}