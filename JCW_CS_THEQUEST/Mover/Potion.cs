using System;
using System.Drawing;
using System.Threading;

namespace JCW_CS_THEQUEST.Mover
{
    abstract class Potion : Weapon
    {
        private bool isUsed;
        public bool IsUsed { get { return isUsed; } set { isUsed = value; } }
        public Potion(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.Location = location;
            PickedUp = false;
            Damage = 0;
            Range = 0;
            isUsed = false;
        }
        public void Used() { isUsed = true; }
        public override abstract void Attack(Direction direction, Random random);
    }
    class RedPotion : Potion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Potion_Red";
            this.Location = location;
            PickedUp = false;
            Damage = 0;
            Range = 0;
        }
        public override void Attack(Direction direction, Random random)
        {
            this.game.PlayerHitPoints += 10;            
            Used();            
        }
    }

    class BluePotion : Potion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Potion_Blue";
            this.Location = location;
            PickedUp = false;
            Damage = 0;
            Range = 0;
        }
        public override void Attack(Direction direction, Random random)
        {
            this.game.IncreasePlayerHealth(20, random);
            Used();
        }
    }

    class Bomb : Potion
    {
        public Bomb(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.weapon_name = "Bomb";
            this.Location = location;
            PickedUp = false;
            Damage = 10;
            Range = 30;
        }
        public override void Attack(Direction direction, Random random)
        {
            Used();
            this.PictureBox.Location = game.PlayerLocation;
            this.PictureBox.Visible = true;
            this.PictureBox.Enabled = true;

            while(this.PictureBox.Visible)
            {
                PictureBox.Update();
                Thread.Sleep(10);
                switch (direction)
                {
                    case Direction.Up:
                        if(location.Y-10 > game.Boundaries.Top)
                        { 
                            this.location.Y -= 10;
                            this.PictureBox.Location = this.location;
                        }
                        else
                        {
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                            PictureBox.Image = JCW_CS_THEQUEST.Properties.Resources.Explosion;
                            this.PictureBox.Visible = true;
                            this.PictureBox.Enabled = true;
                            int size = PictureBox.Size.Width * 2;
                            while (size >= PictureBox.Size.Width)
                            {
                                Thread.Sleep(10);
                                PictureBox.Scale((float)1.1);
                                PictureBox.Location = location;
                                PictureBox.Update();
                            }
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                        }   
                        break;
                    case Direction.Down:
                        if (location.Y + 10 < game.Boundaries.Bottom)
                        {
                            this.location.Y += 10;
                            this.PictureBox.Location = this.location;
                        }
                        else
                        {
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                            PictureBox.Image = JCW_CS_THEQUEST.Properties.Resources.Explosion;
                            this.PictureBox.Visible = true;
                            this.PictureBox.Enabled = true;
                            int size = PictureBox.Size.Width * 2;
                            while (size >= PictureBox.Size.Width)
                            {
                                Thread.Sleep(10);
                                PictureBox.Scale((float)1.1);
                                PictureBox.Location = location;
                                PictureBox.Update();
                            }
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                        }
                        break;
                    case Direction.Left:
                        if (location.X - 10 > game.Boundaries.Left)
                        {
                            this.location.X -= 10;
                            this.PictureBox.Location = this.location;
                        }
                        else
                        {
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                            PictureBox.Image = JCW_CS_THEQUEST.Properties.Resources.Explosion;
                            this.PictureBox.Visible = true;
                            this.PictureBox.Enabled = true;
                            int size = PictureBox.Size.Width * 2;
                            while (size >= PictureBox.Size.Width)
                            {
                                Thread.Sleep(10);
                                PictureBox.Scale((float)1.1);
                                PictureBox.Location = location;
                                PictureBox.Update();
                            }
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                        }
                        break;
                    case Direction.Right:
                        if (location.X + 10 < game.Boundaries.Right)
                        {
                            this.location.X += 10;
                            this.PictureBox.Location = this.location;
                        }
                        else
                        {
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                            PictureBox.Image = JCW_CS_THEQUEST.Properties.Resources.Explosion;
                            this.PictureBox.Visible = true;
                            this.PictureBox.Enabled = true;
                            int size = PictureBox.Size.Width *2;
                            while (size >= PictureBox.Size.Width)
                            {
                                Thread.Sleep(10);
                                PictureBox.Scale((float)1.1);
                                PictureBox.Location = location;
                                PictureBox.Update();
                            }
                            this.PictureBox.Visible = false;
                            this.PictureBox.Enabled = false;
                        }
                        break;
                }
                foreach (Enemy enemy in game.Enemies)
                {
                    if (NearBy(enemy.Location, location, Range))
                    {
                        this.PictureBox.Visible = false;
                        this.PictureBox.Enabled = false;
                        PictureBox.Image = JCW_CS_THEQUEST.Properties.Resources.Explosion;
                        this.PictureBox.Visible = true;
                        this.PictureBox.Enabled = true;
                        int size = PictureBox.Size.Width * 2;
                        while (size >= PictureBox.Size.Width)
                        {
                            Thread.Sleep(10);
                            PictureBox.Scale((float)1.1);
                            PictureBox.Location = location;
                            PictureBox.Update();
                        }
                        this.PictureBox.Visible = false;
                        this.PictureBox.Enabled = false;
                        enemy.Hit(Damage);
                    }
                }
            }

        }
    }
}
