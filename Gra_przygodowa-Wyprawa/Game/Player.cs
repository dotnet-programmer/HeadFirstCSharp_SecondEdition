using Gra_przygodowa_Wyprawa.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Gra_przygodowa_Wyprawa
{
	internal class Player : Mover
	{
		private Weapon equippedWeapon;
		public Weapon EquippedWeapon => equippedWeapon;

		private int hitPoints;
		public int HitPoints => hitPoints;

		private readonly List<Weapon> inventory = new List<Weapon>();
		public List<string> Weapons
		{
			get
			{
				List<string> names = new List<string>();
				foreach (var item in inventory)
				{
					names.Add(item.Name);
				}

				return names;
			}
		}

		public Player(Game game, Point location) : base(game, location) => hitPoints = 10;

		public void Hit(int maxDamage, Random random) => hitPoints -= random.Next(1, maxDamage);

		public void IncreaseHealth(int health, Random random) => hitPoints += random.Next(1, health);

		public void Equip(string weaponName)
		{
			foreach (var item in inventory)
			{
				if (item.Name == weaponName)
				{
					equippedWeapon = item;
				}
			}
		}

		public void Move(Direction direction, Stats stats)
		{
			base.location = Move(direction, game.Boundaries);
			if (!game.WeaponInRoom.PickedUp)
			{
				if (game.WeaponInRoom.Nearby(base.location, 5))
				{
					inventory.Add(game.WeaponInRoom);
					game.WeaponInRoom.PickUpWeapon();
					stats.FindItems++;
					if (inventory.Count == 1)
					{
						Equip(game.WeaponInRoom.Name);
					}
				}
			}
		}

		public void Attack(Direction direction, Random random, Stats stats)
		{
			if (equippedWeapon == null)
			{
				return;
			}

			equippedWeapon.Attack(direction, random, stats);

			if (equippedWeapon is IPotion)
			{
				inventory.RemoveAt(inventory.IndexOf(equippedWeapon));
			}
		}
	}
}