using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Direction : int { Up, Down, Left, Right};

namespace JCW_CS_THEQUEST
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } set { location = value; } }

        protected Game game;
        protected Random Randomizer;

        private int hitPoints; // 0 되면 죽음
        public int HitPoints { get { return hitPoints; } set { hitPoints = value; } }


        // 라벨================================================================
        protected Label label;
        public Label Label { get { return label; } set { label = value; } }
        protected Label label_HitPoints;
        public Label Label_HitPoints { get { return label_HitPoints; } set { label_HitPoints = value; } }



        // 픽쳐 박스================================================================
        protected PictureBox picture_Box;
        public PictureBox PictureBox 
        { 
            get { return picture_Box; }
            set { 
                picture_Box = value; 
                picture_Box.Location = location;
                picture_Box.Visible = true;
            } 
        }

        // 생성자 ================================================================
        public Mover() { }

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            Randomizer = new Random(Guid.NewGuid().GetHashCode());
        }
        
        //=========================================================================
        virtual public void Update()
        {
            PictureBox.Location = Location;
            Label_HitPoints.Text = hitPoints.ToString();
        }

        public bool NearBy(Point locationToCheck, int distance)
        {
            return (Math.Abs(location.X - locationToCheck.X) < distance
                && (Math.Abs(location.Y - locationToCheck.Y) < distance));
        }

        public bool NearBy(Point locationToCheck, Point PlayerLocation, int distance)
        {
            return (Math.Abs(PlayerLocation.X - locationToCheck.X) < distance
                && (Math.Abs(PlayerLocation.Y - locationToCheck.Y) < distance));
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
            }
            return newLocation;
        }
        public Point Move(Direction direction, Point Player_Location, Rectangle boundaries)
        {            
            switch (direction)
            {
                case Direction.Up:
                    if (Player_Location.Y - MoveInterval >= boundaries.Top)
                        Player_Location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (Player_Location.Y + MoveInterval <= boundaries.Bottom)
                        Player_Location.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (Player_Location.X - MoveInterval >= boundaries.Left)
                        Player_Location.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (Player_Location.X + MoveInterval <= boundaries.Right)
                        Player_Location.X += MoveInterval;
                    break;
                default:
                    break;
            }
            return Player_Location;
        }
    }

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
            
            foreach(Weapon weapon in game.WeaponInRoom)
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
                else if(weapon.IsEquipped == true)
                {
                    weapon.SetEquipped();
                }
            }

        }

        public void Attack(Direction direction, Random random)
        {

        }
    }

    abstract class Enemy : Mover
    {
        protected string enemy_name;
        private const int NearPlayerDistance = 25;
        public bool Dead
        {
            get
            {
                return HitPoints <= 0;
            }
        }

        public string EnemyName { get { return enemy_name; } set { enemy_name = value; } }

        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            this.HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (NearBy(game.PlayerLocation, NearPlayerDistance));
        }

        public void Attack(Direction direction, int damage)
        {

            game.HitPlayer(2, Randomizer);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;

            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;

            return directionToMove;
        }
    }

    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) 
        {
            enemy_name = "Bat";
        }
        public override void Move(Random random)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            int temp = random.Next(1, 3); // 랜덤으로 1이나 2
            Direction dir = Direction.Up;
            if (temp == 1) // 1일 때에는 랜덤하게 움직임.
            {
                temp = random.Next(1, 5);
                switch(temp)
                {
                    case 1:
                        dir = Direction.Left;
                        break;
                    case 2:
                        dir = Direction.Right;
                        break;
                    case 3:
                        dir = Direction.Up;
                        break;
                    case 4:
                        dir = Direction.Down;
                        break;
                }
            }
            else // 2일 때에는 플레이어 쪽으로 움직임
            {
                dir = FindPlayerDirection(game.PlayerLocation);
            }

            Move(dir, game.Boundaries);
            if (NearPlayer())
            {
                Attack(dir, 2);
            }
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {
            enemy_name = "Ghost";
            //Label.Text = "label_Ghost";
        }
        public override void Move(Random random)
        {
            //random = new Random();
            int temp = random.Next(1, 4); // 랜덤으로 1이나 2
            Direction dir = Direction.Down;
            if (temp == 1) // 1일 때에는 플레이어 쪽으로 움직임.
            {
                dir = FindPlayerDirection(game.PlayerLocation);
                Move(dir, game.PlayerLocation, game.Boundaries);
                
            }
            if (NearPlayer())
                Attack(dir, 3);
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            enemy_name = "Ghoul";
            //Label.Text = "label_Ghoul";
        }
        public override void Move(Random random)
        {
            //random = new Random();
            int temp = random.Next(1, 4); // 랜덤으로 1이나 2
            Direction dir = Direction.Down;
            if (temp <= 2) // 1~2일 때에는 플레이어 쪽으로 움직임.
            {
                dir = FindPlayerDirection(game.PlayerLocation);
                Move(dir, game.PlayerLocation, game.Boundaries);
            }
            if (NearPlayer())
                Attack(dir, 4);
        }
    }

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
            for (int distance=0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if(NearBy(enemy.Location, target, radius))
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
