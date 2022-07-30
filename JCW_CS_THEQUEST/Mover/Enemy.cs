using System;
using System.Drawing;

namespace JCW_CS_THEQUEST.Mover
{
    abstract class Enemy : Mover
    {
        protected string enemy_name;
        private const int NearPlayerDistance = 25;
        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }
        

        public string EnemyName { get { return enemy_name; } set { enemy_name = value; } }

        // 생성자 ==========================================================
        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            this.HitPoints = hitPoints;
        }

        // 움직이는 함수 =====================================================
        public abstract void Move(Random random);

        public void Hit(int maxDamage)
        {
            HitPoints -= maxDamage;
        }

        protected bool NearPlayer()
        {
            return NearBy(game.PlayerLocation, NearPlayerDistance);
        }

        public void Attack()
        {
            game.HitPlayer(Damage, Randomizer);
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
            Damage = 2;
        }
        public override void Move(Random random)
        {
            if(!Dead)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
                int temp = random.Next(1, 3); // 랜덤으로 1이나 2
                Direction dir = Direction.Up;
                if (temp == 1) // 1일 때에는 랜덤하게 움직임.
                {
                    temp = random.Next(1, 5);
                    switch (temp)
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

                Location = Move(dir, game.Boundaries);
                if (NearPlayer())
                {
                    Attack();
                }
            }            
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {
            enemy_name = "Ghost";
            Damage = 3;
        }
        public override void Move(Random random)
        {
            if(!Dead)
            {
                int temp = random.Next(1, 4); // 랜덤으로 1~3
                if (temp == 1) // 1일 때에는 플레이어 쪽으로 움직임.
                {
                    Direction dir = FindPlayerDirection(game.PlayerLocation);
                    Location = Move(dir, game.Boundaries);
                }
                if (NearPlayer())
                    Attack();
            }
            
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            enemy_name = "Ghoul";
            Damage = 4;
        }
        public override void Move(Random random)
        {
            if(!Dead)
            {
                int temp = random.Next(1, 4); // 랜덤으로 1~3
                if (temp <= 2) // 1~2일 때에는 플레이어 쪽으로 움직임.
                {
                    Direction dir = FindPlayerDirection(game.PlayerLocation);
                    Location = Move(dir, game.Boundaries);
                }
                if (NearPlayer())
                    Attack();
            }
           
        }
    }
}
