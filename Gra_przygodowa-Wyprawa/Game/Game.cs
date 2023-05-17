using Gra_przygodowa_Wyprawa.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gra_przygodowa_Wyprawa
{
	internal class Game
	{
		public List<Enemy> Enemies;
		public Weapon WeaponInRoom;

		private readonly Player player;
		public Point PlayerLocation => player.Location;
		public int PlayerHitPoints => player.HitPoints;
		public List<string> PlayerWeapons => player.Weapons;
		public Weapon EquippedWeapon => player.EquippedWeapon;

		private int level = 0;
		public int Level => level;

		private Rectangle boundaries;
		public Rectangle Boundaries => boundaries;

		public Game(Rectangle boundaries)
		{
			this.boundaries = boundaries;
			player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
		}

		public void Move(Direction direction, Random random, Stats stats) => player.Move(direction, stats); //foreach (var item in Enemies) // item.Move(random);

		public void MoveEnemies(Random random)
		{
			foreach (var item in Enemies)
			{
				item.Move(random);
			}
		}

		public void Equip(string weaponName) => player.Equip(weaponName);

		public bool CheckPlayerInventory(string weaponName) => player.Weapons.Contains(weaponName);

		public void HitPlayer(int maxDamage, Random random) => player.Hit(maxDamage, random);

		public void IncreasePlayerHealth(int health, Random random) => player.IncreaseHealth(health, random);

		public void Attack(Direction direction, Random random, Stats stats) => player.Attack(direction, random, stats);//foreach (var item in Enemies)//	item.Move(random);

		private Point GetRandomLocation(Random random) => new Point(
				boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
				boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);

		public void NewLevel(Random random, GroupBox LblLevel)
		{
			level++;
			LblLevel.Text = "Poziom " + level.ToString();
			switch (level)
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