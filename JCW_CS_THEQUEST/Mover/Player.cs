using System;
using System.Collections.Generic;
using System.Drawing;

namespace JCW_CS_THEQUEST.Mover
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        private List<Weapon> inventory = new List<Weapon>();
        public List<Weapon> Inventory { get { return inventory; } set { inventory = value; } }

        // 새로운 리스트를 만들어서 가지고 있는 웨폰들을 리스트에 담고 반환해주는 함수
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
            HitPoints = 20;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);

            foreach (Weapon weapon in game.WeaponInRoom)
            {
                if (!weapon.PickedUp) // 해당 아이템을 습득하지 않았다면
                {                    
                    if (NearBy(weapon.Location, 15)) // 플레이어 근방 10 거리 안에 있는지
                    {
                        inventory.Add(weapon.PickUpWeapon());
                    }
                }
            }

        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage+1);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health+1);
        }
        public void Equip(string weaponName)
        {
            if (weaponName == "")
            {
                equippedWeapon = null;
                return;
            }
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Weapon_Name == weaponName)
                {
                    equippedWeapon = weapon;                    
                    weapon.SetEquipped(true);
                }
                else
                {
                    weapon.SetEquipped(false);
                }
            }

        }

        public void Attack(Direction direction, Random random)
        {
            Point temp_location = Location;
            switch (direction)
            {
                case Direction.Up:
                    temp_location.Y -= 10;                    
                    break;
                case Direction.Down:
                    temp_location.Y += 10;
                    break;
                case Direction.Left:
                    temp_location.X -= 10;
                    break;
                case Direction.Right:
                    temp_location.X += 10;
                    break;
            }
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                return;
            }
            Move(direction);
        }
    }
}
