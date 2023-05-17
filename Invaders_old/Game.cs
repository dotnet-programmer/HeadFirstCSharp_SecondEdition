using System;
using System.Collections.Generic;
using System.Drawing;

namespace Invaders
{
	internal class Game
	{
		private readonly int score = 0;
		private readonly int livesLeft = 2;
		private readonly int wave = 0;
		private readonly int framesSkipped = 0;

		private Rectangle boundaries;
		private readonly Random random;

		private readonly Direction invaderDirection;
		private readonly List<Invader> invaders;

		private readonly PlayerShip playerShip;
		private readonly List<Shot> playerShots;
		private readonly List<Shot> invaderShots;

		//private Star stars;

		public event EventHandler GameOver;

		public void Draw(Graphics g, int animationCell)
		{
		}

		public void Twinkle()
		{
		}

		public void MovePlayer(Direction direction)
		{
		}

		public void FireShot()
		{
		}

		public void Go()
		{
		}

		private void NextWave()
		{
		}

		private void CheckForPlayerCollisions()
		{
		}

		private void CheckForInvaderCollisions()
		{
		}

		private void MoveInvaders()
		{
		}

		private void ReturnFire()
		{
		}
	}
}