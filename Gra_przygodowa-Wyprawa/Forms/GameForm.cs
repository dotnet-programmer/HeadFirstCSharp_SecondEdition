using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gra_przygodowa_Wyprawa
{
	public partial class GameForm : Form
	{
		private Game game;
		private readonly Random random = new Random();
		private readonly List<PictureBox> pictures = new List<PictureBox>();
		private readonly List<Button> buttons = new List<Button>();
		public string PlayerName { get; set; }
		private readonly Stats stats;
		private int enemiesInLevel = 0;

		private readonly Timer timer = new Timer();

		public GameForm(Stats stats)
		{
			InitializeComponent();

			this.stats = stats;

			AddWeaponsToList();
			AddAttackButtonsToList();

			timer.Interval = 100;
			timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			game.MoveEnemies(random);
			UpdateCharacters();
		}

		private void AddWeaponsToList()
		{
			pictures.Add(BtnSword);
			pictures.Add(BtnMace);
			pictures.Add(BtnBow);
			pictures.Add(BtnBluePotion);
			pictures.Add(BtnRedPotion);
		}

		private void AddAttackButtonsToList()
		{
			buttons.Add(BtnAttackUp);
			buttons.Add(BtnAttackDown);
			buttons.Add(BtnAttackLeft);
			buttons.Add(BtnAttackRight);
		}

		private void Form1_Load(object sender, EventArgs e) => StartGame();

		public void UpdateCharacters()
		{
			// 1. zaktualizuj pozycje gracza i jego statystyki
			PicturePlayer.Location = game.PlayerLocation;
			PlayerHP.Text = game.PlayerHitPoints.ToString();

			bool showBat = false;
			bool showGhost = false;
			bool showGhoul = false;
			int enemiesShown = 0;

			enemiesInLevel = game.Enemies.Count;

			// 2. zaktualizuj pozycje kazdego z przeciwnikow i jego punkty zycia
			foreach (var item in game.Enemies)
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
			switch (game.WeaponInRoom.Name)
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
			BtnSword.Visible = game.CheckPlayerInventory("Miecz");
			BtnMace.Visible = game.CheckPlayerInventory("Buława");
			BtnBow.Visible = game.CheckPlayerInventory("Łuk");
			BtnBluePotion.Visible = game.CheckPlayerInventory("Niebieska mikstura");
			BtnRedPotion.Visible = game.CheckPlayerInventory("Czerwona mikstura");

			if (game.EquippedWeapon != null)
			{
				if (game.EquippedWeapon.Name == "Miecz")
				{
					BtnSword.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (game.EquippedWeapon.Name == "Buława")
				{
					BtnMace.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (game.EquippedWeapon.Name == "Łuk")
				{
					BtnBow.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (game.EquippedWeapon.Name == "Niebieska mikstura")
				{
					BtnBluePotion.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (game.EquippedWeapon.Name == "Czerwona mikstura")
				{
					BtnRedPotion.BorderStyle = BorderStyle.FixedSingle;
				}
			}

			// 5. pozostala czesc metody
			weaponControl.Location = game.WeaponInRoom.Location;

			weaponControl.Visible = !game.WeaponInRoom.PickedUp;

			if (game.PlayerHitPoints <= 0)
			{
				timer.Stop();

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
				timer.Stop();

				game.NewLevel(random, LevelGroupBox);

				if (game.Level == 8)
				{
					MessageBox.Show("Pokonałeś wszystkich przeciwników. Wygrałeś!");
					EndGame(DialogResult.Yes);
				}

				MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
				timer.Start();
				UpdateCharacters();
			}
		}

		private void StartGame()
		{
			stats.GamesCount++;
			game = new Game(new Rectangle(78, 57, 420, 155));
			game.NewLevel(random, LevelGroupBox);
			PlayerLbl.Text = PlayerName;
			UpdateCharacters();
			timer.Start();
		}

		private void EndGame(DialogResult dialogResult)
		{
			if (dialogResult == DialogResult.Yes)
			{
				stats.Win++;
			}
			else if (dialogResult == DialogResult.No)
			{
				stats.Lose++;
			}

			Close();
		}

		// ********** WEAPONS **********
		private void BtnSword_Click(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Miecz"))
			{
				game.Equip("Miecz");
				SetBorders(BtnSword);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnMace_Click(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Buława"))
			{
				game.Equip("Buława");
				SetBorders(BtnMace);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnBow_Click(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Łuk"))
			{
				game.Equip("Łuk");
				SetBorders(BtnBow);
				SetWeaponAttackButtons(false);
			}
		}

		private void BtnBluePotion_Click(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Niebieska mikstura"))
			{
				game.Equip("Niebieska mikstura");
				SetBorders(BtnBluePotion);
				SetWeaponAttackButtons(true);
			}
		}

		private void BtnRedPotion_Click(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Czerwona mikstura"))
			{
				game.Equip("Czerwona mikstura");
				SetBorders(BtnRedPotion);
				SetWeaponAttackButtons(true);
			}
		}

		private void SetBorders(PictureBox pictureBox)
		{
			foreach (var item in pictures)
			{
				item.BorderStyle = item == pictureBox ? BorderStyle.FixedSingle : BorderStyle.None;
			}
		}

		private void SetWeaponAttackButtons(bool isPotion)
		{
			if (isPotion)
			{
				foreach (var item in buttons)
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
				foreach (var item in buttons)
				{
					item.Visible = true;
				}

				BtnAttackUp.Text = "Góra";
			}
		}

		// ********** ATTACK **********
		private void BtnAttackUp_Click(object sender, EventArgs e) => AttackClick(Direction.Up, random, true);

		private void BtnAttackDown_Click(object sender, EventArgs e) => AttackClick(Direction.Down, random);

		private void BtnAttackRight_Click(object sender, EventArgs e) => AttackClick(Direction.Right, random);

		private void BtnAttackLeft_Click(object sender, EventArgs e) => AttackClick(Direction.Left, random);

		private void AttackClick(Direction direction, Random random, bool isPotion = false)
		{
			game.Attack(direction, random, stats);

			if (isPotion)
			{
				stats.DrinkPotions++;
				BtnAttackUp.Visible = false;
				//SetWeaponAttackButtons(!isPotion);
				game.Equip("Miecz");
				SetBorders(BtnSword);
			}
			UpdateCharacters();
		}

		// ********** MOVE **********
		private void BtnMoveUp_Click(object sender, EventArgs e) => MoveClick(Direction.Up);

		private void BtnMoveDown_Click(object sender, EventArgs e) => MoveClick(Direction.Down);

		private void BtnMoveRight_Click(object sender, EventArgs e) => MoveClick(Direction.Right);

		private void BtnMoveLeft_Click(object sender, EventArgs e) => MoveClick(Direction.Left);

		private void MoveClick(Direction direction)
		{
			game.Move(direction, random, stats);
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
				AttackClick(Direction.Up, random);
			}

			if (e.KeyCode == Keys.Down)
			{
				AttackClick(Direction.Down, random);
			}

			if (e.KeyCode == Keys.Left)
			{
				AttackClick(Direction.Left, random);
			}

			if (e.KeyCode == Keys.Right)
			{
				AttackClick(Direction.Right, random);
			}

			if (e.KeyCode == Keys.Escape)
			{
				EndGame(DialogResult.Cancel);
			}
		}
	}
}