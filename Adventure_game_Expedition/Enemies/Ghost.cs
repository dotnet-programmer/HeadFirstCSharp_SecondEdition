using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal class Ghost : Enemy
	{
		public Ghost(Game game, Point location) : base(game, location, 8)
		{
		}

		public override void Move(Random random)
		{
			if (Dead)
			{
				return;
			}

			if (random.Next(3) == 0)
			{
				base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
			}

			if (NearPlayer())
			{
				game.HitPlayer(3, random);
			}
		}
	}
}