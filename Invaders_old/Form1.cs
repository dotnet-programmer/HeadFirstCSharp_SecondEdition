using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Invaders
{
	public partial class Form1 : Form
	{
		private readonly List<Keys> keysPressed = new List<Keys>();

		private readonly bool gameOver;
		private readonly Game game;

		public Form1() => InitializeComponent();

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Q)
			{
				Application.Exit();
			}

			if (gameOver)
			{
				if (e.KeyCode == Keys.S)
				{
					// kod do ponownego uruchomienia gry i restartu zegarow
					return;
				}
			}

			if (e.KeyCode == Keys.Space)
			{
				game.FireShot();
			}

			if (keysPressed.Contains(e.KeyCode))
			{
				keysPressed.Remove(e.KeyCode);
			}

			keysPressed.Add(e.KeyCode);
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (keysPressed.Contains(e.KeyCode))
			{
				keysPressed.Remove(e.KeyCode);
			}
		}

		private void gameTimer_Tick(object sender, EventArgs e)
		{
			game.Go();

			foreach (var item in keysPressed)
			{
				if (item == Keys.Left)
				{
					game.MovePlayer(Direction.Left);
					return;
				}
				else if (item == Keys.Right)
				{
					game.MovePlayer(Direction.Right);
					return;
				}
			}
		}
	}
}