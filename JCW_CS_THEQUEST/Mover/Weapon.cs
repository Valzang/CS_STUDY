using System;
using System.Drawing;
using System.Windows.Forms;

namespace JCW_CS_THEQUEST.Mover
{
    abstract class Weapon : Mover
    {
        protected string weapon_name;
        public string Weapon_Name { get { return weapon_name; } }

        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } set { pickedUp = value; } }

        private bool isEquipped;
        public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }

        public PictureBox InventoryItem;
        public void PickUpWeapon()
        {
            pickedUp = true;
            PictureBox.Visible = false;
            PictureBox.Enabled = false;
            InventoryItem.Visible = true;
            InventoryItem.Enabled = true;
        }
        public void SetEquipped()
        {
            IsEquipped = !IsEquipped;
        }


        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }


        // 생성자 ========================================================
        public Weapon(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
            isEquipped = false;
        }

        public override void Update()
        {
            PictureBox.Location = Location;
            if (IsEquipped == true)
                InventoryItem.BorderStyle = BorderStyle.FixedSingle;
            else
                InventoryItem.BorderStyle = BorderStyle.None;

        }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (NearBy(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
                game.PlayerLocation = target;
            }
            return false;
        }
    }

    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Sword";
            this.Location = location;
            PickedUp = false;
            Damage = 3;
        }
        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
