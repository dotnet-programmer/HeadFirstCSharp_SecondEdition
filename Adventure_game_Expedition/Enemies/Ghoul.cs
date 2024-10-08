﻿using System;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal class Ghoul : Enemy
	{
		public Ghoul(Game game, Point location) : base(game, location, 10)
		{
		}

		public override void Move(Random random)
		{
			if (Dead)
			{
				return;
			}

			int randomInt = random.Next(3);
			if (randomInt == 0 || randomInt == 1)
			{
				location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
			}

			if (NearPlayer())
			{
				game.HitPlayer(4, random);
			}
		}
	}
}