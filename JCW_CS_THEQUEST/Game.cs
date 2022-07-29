using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace JCW_CS_THEQUEST
{
    class Game
    {        // private 변수
        private Player player;          // 플레이어
        private Rectangle boundaries;   // 맵 크기
        private int level = 0;          // 현재 맵

        // public 변수
        public List<Enemy> Enemies;     // 적들 리스트
        public List<Weapon> WeaponInRoom;     // 방안에 있는 무기

        // GetBoundaries
        public Rectangle Boundaries { get { return boundaries; } }

        // 생성자
        public Game() { }
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left, boundaries.Top + 85));
        }

        // player 관련 함수===========================================================
        public Point PlayerLocation { get { return player.Location; } set { player.Location = value; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }
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
        public void SetPictureBox(PictureBox _PB, Label _Name, Label _HitPoints) 
        { 
            player.PictureBox = _PB;
            player.PictureBox.Visible = true;
            player.PictureBox.Location = player.Location;
            player.Label = _Name;
            player.Label_HitPoints = _HitPoints;
            player.Label_HitPoints.Text = player.HitPoints.ToString();
        }

        // Level 관련 함수==========================================================
        public int Level { get { return level; } }
        public void NewLevel(Random random)
        {
            ++level;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new List<Weapon>();
                    WeaponInRoom.Add(new Sword(this, GetRandomLocation(random)));
                    break;
            }
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

       

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }       

    }    
}
