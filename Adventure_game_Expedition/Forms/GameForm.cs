using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Adventure_game_Expedition.Weapons;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Adventure_game_Expedition
{
	public partial class GameForm : Form
	{
		private readonly List<PictureBox> _pictures = new List<PictureBox>();
		private readonly List<Button> _buttons = new List<Button>();

		private readonly Random _random = new Random();
		private readonly Timer _timer = new Timer();

		private readonly string _playerName;
		private readonly Stats _stats;

		private Game _game;
		private int _enemiesShown;

		public GameForm(string playerName, Stats stats)
		{
			InitializeComponent();

			_playerName = playerName;
			_stats = stats;

			AddWeaponsToList();
			AddAttackButtonsToList();

			_timer.Interval = 100;
			_timer.Tick += Timer_Tick;
		}

		#region GameForm events

		private void GameForm_Load(object sender, EventArgs e)
			=> StartGame();

		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				// move
				case Keys.W:
					MoveClick(Direction.Up);
					break;
				case Keys.S:
					MoveClick(Direction.Down);
					break;
				case Keys.A:
					MoveClick(Direction.Left);
					break;
				case Keys.D:
					MoveClick(Direction.Right);
					break;

				// attack
				case Keys.Up:
					AttackClick(Direction.Up, _random);
					break;
				case Keys.Down:
					AttackClick(Direction.Down, _random);
					break;
				case Keys.Left:
					AttackClick(Direction.Left, _random);
					break;
				case Keys.Right:
					AttackClick(Direction.Right, _random);
					break;

				// close game
				case Keys.Escape:
					EndGame(DialogResult.Cancel);
					break;
			}
		}

		#endregion GameForm events

		#region Weapon buttons

		private void BtnSword_Click(object sender, EventArgs e)
			=> WeaponClick(WeaponName.Sword, BtnSword);

		private void BtnMace_Click(object sender, EventArgs e)
			=> WeaponClick(WeaponName.Mace, BtnMace);

		private void BtnBow_Click(object sender, EventArgs e)
			=> WeaponClick(WeaponName.Bow, BtnBow);

		private void BtnBluePotion_Click(object sender, EventArgs e)
			=> WeaponClick(WeaponName.BluePotion, BtnBluePotion, true);

		private void BtnRedPotion_Click(object sender, EventArgs e)
			=> WeaponClick(WeaponName.RedPotion, BtnRedPotion, true);

		#endregion Weapon buttons

		#region Attack buttons

		private void BtnAttackUp_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Up, _random, true);

		private void BtnAttackDown_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Down, _random);

		private void BtnAttackLeft_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Left, _random);

		private void BtnAttackRight_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Right, _random);

		#endregion Attack buttons

		#region Move buttons

		private void BtnMoveUp_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Up);

		private void BtnMoveDown_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Down);

		private void BtnMoveLeft_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Left);

		private void BtnMoveRight_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Right);

		#endregion Move buttons

		private void Timer_Tick(object sender, EventArgs e)
		{
			_game.MoveEnemies(_random);
			UpdateCharacters();
		}

		#region Initialize button lists

		private void AddWeaponsToList()
		{
			_pictures.Add(BtnSword);
			_pictures.Add(BtnMace);
			_pictures.Add(BtnBow);
			_pictures.Add(BtnBluePotion);
			_pictures.Add(BtnRedPotion);
		}

		private void AddAttackButtonsToList()
		{
			_buttons.Add(BtnAttackUp);
			_buttons.Add(BtnAttackDown);
			_buttons.Add(BtnAttackLeft);
			_buttons.Add(BtnAttackRight);
		}

		#endregion Initialize button lists

		#region Game state handling

		private void StartGame()
		{
			_stats.GamesCount++;
			_game = new Game(new Rectangle(78, 57, 420, 155));
			_game.NewLevel(_random, LevelGroupBox);
			PlayerLbl.Text = _playerName;
			UpdateCharacters();
			_timer.Start();
		}

		private void EndGame(DialogResult dialogResult)
		{
			if (dialogResult == DialogResult.Yes)
			{
				_stats.Win++;
			}
			else if (dialogResult == DialogResult.No)
			{
				_stats.Lose++;
			}

			Close();
		}

		#endregion Game state handling

		#region Buttons click handling

		private void AttackClick(Direction direction, Random random, bool isPotion = false)
		{
			_game.Attack(direction, random, _stats);

			if (isPotion)
			{
				_stats.DrinkPotions++;
				BtnAttackUp.Visible = false;
				_game.Equip(WeaponName.Sword);
				SetBorders(BtnSword);
			}
			UpdateCharacters();
		}

		private void MoveClick(Direction direction)
		{
			_game.Move(direction, _stats);
			UpdateCharacters();
		}

		private void WeaponClick(string weaponName, PictureBox weapon, bool isPotion = false)
		{
			if (_game.CheckPlayerInventory(weaponName))
			{
				_game.Equip(weaponName);
				SetBorders(weapon);
				SetWeaponAttackButtons(isPotion);
			}
		}

		private void SetBorders(PictureBox pictureBox)
		{
			foreach (var item in _pictures)
			{
				item.BorderStyle = item == pictureBox ? BorderStyle.FixedSingle : BorderStyle.None;
			}
		}

		private void SetWeaponAttackButtons(bool isPotion)
		{
			if (isPotion)
			{
				foreach (var item in _buttons)
				{
					if (item == BtnAttackUp)
					{
						item.Visible = true;
						item.Text = "Wypij";
					}
					else
					{
						item.Visible = false;
					}
				}
			}
			else
			{
				foreach (var item in _buttons)
				{
					item.Visible = true;
				}

				BtnAttackUp.Text = "Góra";
			}
		}

		private void UpdateCharacters()
		{
			UpdatePlayerPositionAndStatistics();
			UpdateOpponentsPositionAndLifePoints();
			UpdatePictureBoxControlsForWeapons();
			SetWeaponButtonsVisibility();
			SetBorderToEquippedWeapon();
			CheckIfPlayerWin();
			CheckIfGameOver();
		}

		private void UpdatePlayerPositionAndStatistics()
		{
			PicturePlayer.Location = _game.PlayerLocation;
			PlayerHP.Text = _game.PlayerHitPoints.ToString();
		}

		private void UpdateOpponentsPositionAndLifePoints()
		{
			_enemiesShown = 0;

			bool showBat = false;
			bool showGhost = false;
			bool showGhoul = false;

			foreach (var item in _game.Enemies)
			{
				if (!item.Dead)
				{
					_enemiesShown++;

					if (item is Bat)
					{
						PictureBat.Location = item.Location;
						BatHP.Text = item.HitPoints.ToString();
						showBat = true;
					}
					else if (item is Ghost)
					{
						PictureGhost.Location = item.Location;
						GhostHP.Text = item.HitPoints.ToString();
						showGhost = true;
					}
					else if (item is Ghoul)
					{
						PictureGhoul.Location = item.Location;
						GhoulHP.Text = item.HitPoints.ToString();
						showGhoul = true;
					}
				}
			}

			PictureBat.Visible = showBat;
			PictureGhost.Visible = showGhost;
			PictureGhoul.Visible = showGhoul;

			if (!showBat)
			{
				BatHP.Text = "";
			}
			if (!showGhost)
			{
				GhostHP.Text = "";
			}
			if (!showGhoul)
			{
				GhoulHP.Text = "";
			}
		}

		private void UpdatePictureBoxControlsForWeapons()
		{
			PictureSword.Visible = false;
			PictureMace.Visible = false;
			PictureBow.Visible = false;
			PictureBluePotion.Visible = false;
			PictureRedPotion.Visible = false;

			Control weaponControl = null;
			switch (_game.WeaponInRoom.Name)
			{
				case WeaponName.Sword:
					weaponControl = PictureSword;
					break;
				case WeaponName.Mace:
					weaponControl = PictureMace;
					break;
				case WeaponName.Bow:
					weaponControl = PictureBow;
					break;
				case WeaponName.BluePotion:
					weaponControl = PictureBluePotion;
					break;
				case WeaponName.RedPotion:
					weaponControl = PictureRedPotion;
					break;
			}
			weaponControl.Location = _game.WeaponInRoom.Location;
			weaponControl.Visible = !_game.WeaponInRoom.PickedUp;
		}

		private void SetWeaponButtonsVisibility()
		{
			BtnSword.Visible = _game.CheckPlayerInventory(WeaponName.Sword);
			BtnMace.Visible = _game.CheckPlayerInventory(WeaponName.Mace);
			BtnBow.Visible = _game.CheckPlayerInventory(WeaponName.Bow);
			BtnBluePotion.Visible = _game.CheckPlayerInventory(WeaponName.BluePotion);
			BtnRedPotion.Visible = _game.CheckPlayerInventory(WeaponName.RedPotion);
		}

		private void SetBorderToEquippedWeapon()
		{
			if (_game.EquippedWeapon != null)
			{
				if (_game.EquippedWeapon.Name == WeaponName.Sword)
				{
					BtnSword.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == WeaponName.Mace)
				{
					BtnMace.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == WeaponName.Bow)
				{
					BtnBow.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == WeaponName.BluePotion)
				{
					BtnBluePotion.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == WeaponName.RedPotion)
				{
					BtnRedPotion.BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		private void CheckIfPlayerWin()
		{
			if (_enemiesShown == 0)
			{
				_timer.Stop();
				_game.NewLevel(_random, LevelGroupBox);

				if (_game.Level == 8)
				{
					MessageBox.Show("Pokonałeś wszystkich przeciwników. Wygrałeś!");
					EndGame(DialogResult.Yes);
				}

				MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
				_timer.Start();
				UpdateCharacters();
			}
		}

		private void CheckIfGameOver()
		{
			if (_game.PlayerHitPoints <= 0)
			{
				_timer.Stop();

				if (MessageBox.Show("Zostałeś zabity!\r\nZagrać jeszcze raz?", "Koniec gry!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					StartGame();
				}
				else
				{
					EndGame(DialogResult.No);
				}
			}
		}

		#endregion Buttons click handling
	}
}