using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Adventure_game_Expedition
{
	public partial class GameForm : Form
	{
		private Game _game;
		private readonly Random _random = new Random();
		private readonly List<PictureBox> _pictures = new List<PictureBox>();
		private readonly List<Button> _buttons = new List<Button>();
		private readonly Stats _stats;
		private int _enemiesInLevel = 0;
		private readonly Timer _timer = new Timer();

		public GameForm(Stats stats)
		{
			InitializeComponent();

			_stats = stats;

			AddWeaponsToList();
			AddAttackButtonsToList();

			_timer.Interval = 100;
			_timer.Tick += Timer_Tick;
		}

		public string PlayerName { get; set; }

		public void UpdateCharacters()
		{
			// 1. zaktualizuj pozycje gracza i jego statystyki
			PicturePlayer.Location = _game.PlayerLocation;
			PlayerHP.Text = _game.PlayerHitPoints.ToString();

			bool showBat = false;
			bool showGhost = false;
			bool showGhoul = false;
			int enemiesShown = 0;

			_enemiesInLevel = _game.Enemies.Count;

			// 2. zaktualizuj pozycje kazdego z przeciwnikow i jego punkty zycia
			foreach (var item in _game.Enemies)
			{
				if (item is Bat && !item.Dead)
				{
					PictureBat.Location = item.Location;
					BatHP.Text = item.HitPoints.ToString();
					showBat = true;
					enemiesShown++;
				}
				if (item is Ghost && !item.Dead)
				{
					PictureGhost.Location = item.Location;
					GhostHP.Text = item.HitPoints.ToString();
					showGhost = true;
					enemiesShown++;
				}
				if (item is Ghoul && !item.Dead)
				{
					PictureGhoul.Location = item.Location;
					GhoulHP.Text = item.HitPoints.ToString();
					showGhoul = true;
					enemiesShown++;
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

			// 3. zaktualizuj kontrolki picturebox dla broni
			PictureSword.Visible = false;
			PictureMace.Visible = false;
			PictureBow.Visible = false;
			PictureBluePotion.Visible = false;
			PictureRedPotion.Visible = false;
			Control weaponControl = null;
			switch (_game.WeaponInRoom.Name)
			{
				case "Miecz":
					weaponControl = PictureSword;
					break;
				case "Buława":
					weaponControl = PictureMace;
					break;
				case "Łuk":
					weaponControl = PictureBow;
					break;
				case "Niebieska mikstura":
					weaponControl = PictureBluePotion;
					break;
				case "Czerwona mikstura":
					weaponControl = PictureRedPotion;
					break;
			}
			weaponControl.Visible = true;

			// 4. ustaw właściwość visible kazdej kontrolki picturebox inwentarza
			BtnSword.Visible = _game.CheckPlayerInventory("Miecz");
			BtnMace.Visible = _game.CheckPlayerInventory("Buława");
			BtnBow.Visible = _game.CheckPlayerInventory("Łuk");
			BtnBluePotion.Visible = _game.CheckPlayerInventory("Niebieska mikstura");
			BtnRedPotion.Visible = _game.CheckPlayerInventory("Czerwona mikstura");

			if (_game.EquippedWeapon != null)
			{
				if (_game.EquippedWeapon.Name == "Miecz")
				{
					BtnSword.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == "Buława")
				{
					BtnMace.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == "Łuk")
				{
					BtnBow.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == "Niebieska mikstura")
				{
					BtnBluePotion.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (_game.EquippedWeapon.Name == "Czerwona mikstura")
				{
					BtnRedPotion.BorderStyle = BorderStyle.FixedSingle;
				}
			}

			// 5. pozostala czesc metody
			weaponControl.Location = _game.WeaponInRoom.Location;

			weaponControl.Visible = !_game.WeaponInRoom.PickedUp;

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

			if (enemiesShown == 0)
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

		private void Timer_Tick(object sender, EventArgs e)
		{
			_game.MoveEnemies(_random);
			UpdateCharacters();
		}

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

		private void Form1_Load(object sender, EventArgs e)
			=> StartGame();

		private void StartGame()
		{
			_stats.GamesCount++;
			_game = new Game(new Rectangle(78, 57, 420, 155));
			_game.NewLevel(_random, LevelGroupBox);
			PlayerLbl.Text = PlayerName;
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

		// ********** WEAPONS **********
		private void BtnSword_Click(object sender, EventArgs e)
		{
			if (_game.CheckPlayerInventory("Miecz"))
			{
				_game.Equip("Miecz");
				SetBorders(BtnSword);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnMace_Click(object sender, EventArgs e)
		{
			if (_game.CheckPlayerInventory("Buława"))
			{
				_game.Equip("Buława");
				SetBorders(BtnMace);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnBow_Click(object sender, EventArgs e)
		{
			if (_game.CheckPlayerInventory("Łuk"))
			{
				_game.Equip("Łuk");
				SetBorders(BtnBow);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnBluePotion_Click(object sender, EventArgs e)
		{
			if (_game.CheckPlayerInventory("Niebieska mikstura"))
			{
				_game.Equip("Niebieska mikstura");
				SetBorders(BtnBluePotion);
				SetWeaponAttackButtons(true);
			}
		}

		private void BtnRedPotion_Click(object sender, EventArgs e)
		{
			if (_game.CheckPlayerInventory("Czerwona mikstura"))
			{
				_game.Equip("Czerwona mikstura");
				SetBorders(BtnRedPotion);
				SetWeaponAttackButtons(true);
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

		// ********** ATTACK **********
		private void BtnAttackUp_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Up, _random, true);

		private void BtnAttackDown_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Down, _random);

		private void BtnAttackRight_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Right, _random);

		private void BtnAttackLeft_Click(object sender, EventArgs e)
			=> AttackClick(Direction.Left, _random);

		private void AttackClick(Direction direction, Random random, bool isPotion = false)
		{
			_game.Attack(direction, random, _stats);

			if (isPotion)
			{
				_stats.DrinkPotions++;
				BtnAttackUp.Visible = false;
				//SetWeaponAttackButtons(!isPotion);
				_game.Equip("Miecz");
				SetBorders(BtnSword);
			}
			UpdateCharacters();
		}

		// ********** MOVE **********
		private void BtnMoveUp_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Up);

		private void BtnMoveDown_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Down);

		private void BtnMoveRight_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Right);

		private void BtnMoveLeft_Click(object sender, EventArgs e)
			=> MoveClick(Direction.Left);

		private void MoveClick(Direction direction)
		{
			_game.Move(direction, _random, _stats);
			UpdateCharacters();
		}

		// Keys clicked on Form
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// move
			if (e.KeyCode == Keys.W)
			{
				MoveClick(Direction.Up);
			}

			if (e.KeyCode == Keys.S)
			{
				MoveClick(Direction.Down);
			}

			if (e.KeyCode == Keys.A)
			{
				MoveClick(Direction.Left);
			}

			if (e.KeyCode == Keys.D)
			{
				MoveClick(Direction.Right);
			}

			// attack
			if (e.KeyCode == Keys.Up)
			{
				AttackClick(Direction.Up, _random);
			}

			if (e.KeyCode == Keys.Down)
			{
				AttackClick(Direction.Down, _random);
			}

			if (e.KeyCode == Keys.Left)
			{
				AttackClick(Direction.Left, _random);
			}

			if (e.KeyCode == Keys.Right)
			{
				AttackClick(Direction.Right, _random);
			}

			if (e.KeyCode == Keys.Escape)
			{
				EndGame(DialogResult.Cancel);
			}
		}
	}
}