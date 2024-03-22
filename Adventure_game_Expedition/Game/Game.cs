using Adventure_game_Expedition.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Adventure_game_Expedition
{
	internal class Game
	{
		public List<Enemy> Enemies;
		public Weapon WeaponInRoom;

		private readonly Player _player;
		private int _level = 0;
		private Rectangle _boundaries;

		public Game(Rectangle boundaries)
		{
			_boundaries = boundaries;
			_player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
		}

		public Point PlayerLocation 
			=> _player.Location;

		public int PlayerHitPoints 
			=> _player.HitPoints;

		public List<string> PlayerWeapons 
			=> _player.Weapons;

		public Weapon EquippedWeapon 
			=> _player.EquippedWeapon;

		public int Level 
			=> _level;

		public Rectangle Boundaries 
			=> _boundaries;

		public void Move(Direction direction, Random random, Stats stats) 
			=> _player.Move(direction, stats); //foreach (var item in Enemies) // item.Move(random);

		public void MoveEnemies(Random random)
		{
			foreach (var item in Enemies)
			{
				item.Move(random);
			}
		}

		public void Equip(string weaponName) 
			=> _player.Equip(weaponName);

		public bool CheckPlayerInventory(string weaponName) 
			=> _player.Weapons.Contains(weaponName);

		public void HitPlayer(int maxDamage, Random random) 
			=> _player.Hit(maxDamage, random);

		public void IncreasePlayerHealth(int health, Random random) 
			=> _player.IncreaseHealth(health, random);

		public void Attack(Direction direction, Random random, Stats stats) 
			=> _player.Attack(direction, random, stats);
		//foreach (var item in Enemies)//	item.Move(random);

		private Point GetRandomLocation(Random random) 
			=> new Point(
				_boundaries.Left + random.Next(_boundaries.Right / 10 - _boundaries.Left / 10) * 10,
				_boundaries.Top + random.Next(_boundaries.Bottom / 10 - _boundaries.Top / 10) * 10);

		public void NewLevel(Random random, GroupBox LblLevel)
		{
			_level++;
			LblLevel.Text = "Poziom " + _level.ToString();
			switch (_level)
			{
				case 1:
					Enemies = new List<Enemy>() {
						new Bat(this, GetRandomLocation(random)) };
					WeaponInRoom = new Sword(this, GetRandomLocation(random));
					break;
				case 2:
					Enemies = new List<Enemy>() {
						new Ghost(this, GetRandomLocation(random)) };
					WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
					break;
				case 3:
					Enemies = new List<Enemy>() {
						new Ghoul(this, GetRandomLocation(random)) };
					WeaponInRoom = new Bow(this, GetRandomLocation(random));
					break;
				case 4:
					Enemies = new List<Enemy>(){
						new Bat(this, GetRandomLocation(random)),
						new Ghost(this, GetRandomLocation(random)) };
					WeaponInRoom = !CheckPlayerInventory("bow") ? new Bow(this, GetRandomLocation(random)) : (Weapon)new BluePotion(this, GetRandomLocation(random));
					break;
				case 5:
					Enemies = new List<Enemy>(){
						new Bat(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random)) };
					WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
					break;
				case 6:
					Enemies = new List<Enemy>(){
						new Ghost(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random)) };
					WeaponInRoom = new Mace(this, GetRandomLocation(random));
					break;
				case 7:
					Enemies = new List<Enemy>(){
						new Bat(this, GetRandomLocation(random)),
						new Ghost(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random)) };
					WeaponInRoom = !CheckPlayerInventory("mace") ? new Mace(this, GetRandomLocation(random)) : (Weapon)new RedPotion(this, GetRandomLocation(random));
					break;
				case 8:
					break;
			}
		}
	}
}