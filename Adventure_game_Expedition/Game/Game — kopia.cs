﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Gra_przygodowa_Wyprawa.Weapons;

namespace Gra_przygodowa_Wyprawa
{
	class Game
	{
		public List<Enemy> Enemies;
		public Weapon WeaponInRoom;

		private readonly Player player;
		public Point PlayerLocation { get => player.Location; }
		public int PlayerHitPoints { get => player.HitPoints; }
		public List<string> PlayerWeapons { get => player.Weapons; }
		public Weapon EquippedWeapon { get => player.EquippedWeapon; }

		private int level = 0;
		public int Level { get => level; }

		private Rectangle boundaries;
		public Rectangle Boundaries { get => boundaries; }

		public Game(Rectangle boundaries)
		{
			this.boundaries = boundaries;
			player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
		}

		public void Move(Direction direction, Random random, Stats stats)
		{
			player.Move(direction, stats);
			foreach (var item in Enemies)
				item.Move(random);
		}

		public void Equip(string weaponName)
		{
			player.Equip(weaponName);
		}

		public bool CheckPlayerInventory(string weaponName)
		{
			return player.Weapons.Contains(weaponName);
		}

		public void HitPlayer(int maxDamage, Random random)
		{
			player.Hit(maxDamage, random);
		}

		public void IncreasePlayerHealth(int health, Random random)
		{
			player.IncreaseHealth(health, random);
		}

		public void Attack(Direction direction, Random random, Stats stats)
		{
			player.Attack(direction, random, stats);
			foreach (var item in Enemies)
				item.Move(random);
		}

		private Point GetRandomLocation(Random random)
		{
			return new Point(
				boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
				boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
		}

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

					if (!CheckPlayerInventory("bow"))
						WeaponInRoom = new Bow(this, GetRandomLocation(random));
					else
						WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
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

					if (!CheckPlayerInventory("mace"))
						WeaponInRoom = new Mace(this, GetRandomLocation(random));
					else
						WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
					break;
				case 8:
					break;
			}
		}
	}
}
