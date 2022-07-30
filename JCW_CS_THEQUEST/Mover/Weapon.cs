using System;
using System.Drawing;
using System.Windows.Forms;

namespace JCW_CS_THEQUEST.Mover
{
    abstract class Weapon : Mover
    {
        protected string weapon_name;
        public string Weapon_Name { get { return weapon_name; } set { weapon_name = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }


        private int range;
        public int Range { get { return range; } set { range = value; } }

        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } set { pickedUp = value; } }

        private bool isEquipped;
        public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }

        public PictureBox InventoryItem;
        public Weapon PickUpWeapon()
        {
            pickedUp = true;
            PictureBox.Visible = false;
            PictureBox.Enabled = false;
            InventoryItem.Visible = true;
            InventoryItem.Enabled = true;

            return this;
        }
        public void SetEquipped(bool equip)
        {
            IsEquipped = equip;
            if(IsEquipped)
            {
                InventoryItem.BorderStyle = BorderStyle.FixedSingle;
            }
            else
                InventoryItem.BorderStyle = BorderStyle.None;
        }




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
            PictureBox.Update();
            if (IsEquipped == true)
                InventoryItem.BorderStyle = BorderStyle.FixedSingle;
            else
                InventoryItem.BorderStyle = BorderStyle.None;

        }

        public abstract void Attack(Direction direction, Random random);

        protected void DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (NearBy(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage);
                    }
                }
                target = Move(direction, target, game.Boundaries);
                game.PlayerLocation = target;
            }
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
            Range = 20;
        }
        public override void Attack(Direction direction, Random random)
        {
            foreach (Enemy enemy in game.Enemies)
            {
                if (NearBy(enemy.Location, game.PlayerLocation, Range))
                    enemy.Hit(Damage);
            }
        }
    }

    class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Bow";
            this.Location = location;
            PickedUp = false;
            Damage = 1;
            Range = 120;
        }
        public override void Attack(Direction direction, Random random)
        {
            Point MaxAttackPos = this.location;
            switch(direction)
            {
                case Direction.Left:
                    MaxAttackPos.X -= Range;
                    break;
                case Direction.Right:
                    MaxAttackPos.X += Range;
                    break;
                case Direction.Up:
                    MaxAttackPos.Y -= Range;
                    break;
                case Direction.Down:
                    MaxAttackPos.Y += Range;
                    break;
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (NearBy(enemy.Location, game.PlayerLocation, Range))
                { 
                    switch(direction)
                    {
                        case Direction.Up:
                            if (Math.Abs(enemy.Location.X - game.PlayerLocation.X) < 20
                               && enemy.Location.Y >= game.PlayerLocation.Y)
                            {
                                enemy.Hit(Damage);
                                return;
                            }
                            break;
                        case Direction.Down:
                            if (Math.Abs(enemy.Location.X - game.PlayerLocation.X) < 20
                                && enemy.Location.Y <= game.PlayerLocation.Y)
                            { 
                                enemy.Hit(Damage);
                                return;
                            }
                            break;
                        case Direction.Left:
                            if (Math.Abs(enemy.Location.Y - game.PlayerLocation.Y) < 20
                               && enemy.Location.X <= game.PlayerLocation.X)
                            {
                                enemy.Hit(Damage);
                                return;
                            }
                            break;
                        case Direction.Right:
                            if (Math.Abs(enemy.Location.Y - game.PlayerLocation.Y) < 20
                               && enemy.Location.X >= game.PlayerLocation.X)
                            {
                                enemy.Hit(Damage);
                                return;
                            }
                            break;
                    }               
                }
            }
        }
    }

    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Mace";
            this.Location = location;
            PickedUp = false;
            Damage = 6;
            Range = 30;
        }
        public override void Attack(Direction direction, Random random)
        {
            foreach (Enemy enemy in game.Enemies)
            {
                if (NearBy(enemy.Location, game.PlayerLocation, Range))
                    enemy.Hit(Damage);
            }
        }
    }   

}
