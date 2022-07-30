using System;
using System.Collections.Generic;
using System.Drawing;

namespace JCW_CS_THEQUEST.Mover
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Weapon_Name);
                return names;
            }
        }
        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);

            foreach (Weapon weapon in game.WeaponInRoom)
            {
                if (!weapon.PickedUp) // 해당 아이템을 습득하지 않았다면
                {
                    if (NearBy(location, 10)) // 플레이어 근방 10 거리 안에 있는지
                    {
                        weapon.PickUpWeapon();
                    }
                }
            }

        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Weapon_Name == weaponName)
                {
                    equippedWeapon = weapon;
                    weapon.SetEquipped();
                }
                else if (weapon.IsEquipped == true)
                {
                    weapon.SetEquipped();
                }
            }

        }

        public void Attack(Direction direction, Random random)
        {

        }
    }
}
