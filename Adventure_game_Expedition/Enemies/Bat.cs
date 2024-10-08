﻿using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal class Bat : Enemy
	{
		public Bat(Game game, Point location) : base(game, location, 6)
		{
		}

		public override void Move(Random random)
		{
			if (Dead)
			{
				return;
			}

			Direction direction = (random.Next(2) == 0) ? (Direction)random.Next(4) : FindPlayerDirection(game.PlayerLocation);
			location = Move(direction, game.Boundaries);

			if (NearPlayer())
			{
				game.HitPlayer(2, random);
			}
		}
	}
}