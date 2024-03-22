using Adventure_game_Expedition.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Adventure_game_Expedition
{
	internal class Player : Mover
	{
		private readonly List<Weapon> _inventory = new List<Weapon>();

		private Weapon _equippedWeapon;
		private int _hitPoints;

		public Player(Game game, Point location) : base(game, location) 
			=> _hitPoints = 10;

		public Weapon EquippedWeapon 
			=> _equippedWeapon;

		public int HitPoints
			=> _hitPoints;

		public List<string> Weapons
		{
			get
			{
				List<string> names = new List<string>();
				foreach (var item in _inventory)
				{
					names.Add(item.Name);
				}

				return names;
			}
		}

		public void Hit(int maxDamage, Random random) 
			=> _hitPoints -= random.Next(1, maxDamage);

		public void IncreaseHealth(int health, Random random) 
			=> _hitPoints += random.Next(1, health);

		public void Equip(string weaponName)
		{
			foreach (var item in _inventory)
			{
				if (item.Name == weaponName)
				{
					_equippedWeapon = item;
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
					_inventory.Add(game.WeaponInRoom);
					game.WeaponInRoom.PickUpWeapon();
					stats.FindItems++;
					if (_inventory.Count == 1)
					{
						Equip(game.WeaponInRoom.Name);
					}
				}
			}
		}

		public void Attack(Direction direction, Random random, Stats stats)
		{
			if (_equippedWeapon == null)
			{
				return;
			}

			_equippedWeapon.Attack(direction, random, stats);

			if (_equippedWeapon is IPotion)
			{
				_inventory.RemoveAt(_inventory.IndexOf(_equippedWeapon));
			}
		}
	}
}