using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Invaders
{
	public partial class Form1 : Form
	{
		private readonly List<Keys> _keysPressed = new List<Keys>();

		private readonly bool _gameOver;
		private readonly Game _game;

		public Form1()
			=> InitializeComponent();

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Q)
			{
				Application.Exit();
			}

			if (_gameOver)
			{
				if (e.KeyCode == Keys.S)
				{
					// kod do ponownego uruchomienia gry i restartu zegarow
					return;
				}
			}

			if (e.KeyCode == Keys.Space)
			{
				_game.FireShot();
			}

			if (_keysPressed.Contains(e.KeyCode))
			{
				_keysPressed.Remove(e.KeyCode);
			}

			_keysPressed.Add(e.KeyCode);
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (_keysPressed.Contains(e.KeyCode))
			{
				_keysPressed.Remove(e.KeyCode);
			}
		}

		private void gameTimer_Tick(object sender, EventArgs e)
		{
			_game.Go();

			foreach (var item in _keysPressed)
			{
				if (item == Keys.Left)
				{
					_game.MovePlayer(Direction.Left);
					return;
				}
				else if (item == Keys.Right)
				{
					_game.MovePlayer(Direction.Right);
					return;
				}
			}
		}
	}
}