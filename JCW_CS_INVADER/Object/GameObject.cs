using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;

namespace JCW_CS_INVADER.Object
{
    class GameObject
    {

        List<PictureBox> Invaders_Img;

        // 적 관련
        List<Invader> InvadersList = new List<Invader>();
        List<Shot> Missile_Invader = new List<Shot>();

        // 반짝별
        List<Star> TwinklingStar = new List<Star>();

        // 플레이어 관련
        Player curPlayer = null;
        List<Shot> Missile_Player = new List<Shot>();


        // 싱글톤으로 관리 =====================================
        private static GameObject gameObject;
        public static GameObject Instance()
        {
            if (gameObject == null)
                gameObject = new GameObject();
            return gameObject;
        }

        public void SetImg(List<PictureBox> pictureBoxes)
        {
            Invaders_Img = pictureBoxes;
        }
        // =====================================================

        // 현재 화면 크기
        Rectangle curScreenSize;
        public void SetScreenSize(Rectangle _Val) { curScreenSize.Width = _Val.Width; curScreenSize.Height = _Val.Height; }

        int WaveCount = 0;

        public int GetEnemyShots()
        {
            return Missile_Invader.Count;
        }
        public int GetPlayerShots()
        {
            return Missile_Player.Count;
        }

        public List<Star> GetStars()
        {
            return TwinklingStar;
        }

        public Player GetPlayer()
        {
            return curPlayer;
        }
        public List<Invader> GetEnemyList()
        {
            return InvadersList;
        }

        public void AddEnemyShot(Point _enemyPos, Mover _shooter)
        {
            Missile_Invader.Add(new EnemyShot(_enemyPos, Invaders_Img[7], _shooter));
        }
        public void AddPlayerShot(Point _playerPos, Mover _shooter)
        {
            Missile_Invader.Add(new PlayerShot(_playerPos, Invaders_Img[6], _shooter));
        }

        public void Invader_Init(List<PictureBox> _Img) 
        {
            Invaders_Img = _Img;
            InvadersList.Clear();             
            for (int i=0; i<5; ++i)
            {
                for (int j=0; j<6; ++j)
                {
                    switch(i)
                    {
                        case 0:
                            InvadersList.Add(new Enemy_Star(WaveCount, Invaders_Img[i]));
                            break;
                        case 1:
                            InvadersList.Add(new Enemy_Spaceship(WaveCount, Invaders_Img[i]));
                            break;
                        case 2:
                            InvadersList.Add(new Enemy_Saucer(WaveCount, Invaders_Img[i]));
                            break;
                        case 3:
                            InvadersList.Add(new Enemy_Bug(WaveCount, Invaders_Img[i]));
                            break;
                        case 4:
                            InvadersList.Add(new Enemy_Satellite(WaveCount, Invaders_Img[i]));
                            break;
                    }
                }
            }
        }
        public void Player_Init()
        {
            curPlayer = new Player(Invaders_Img[5], curScreenSize);          
        }

        public void Star_Init()
        {
            for (int i=0 ; i<100 ; ++i)
                TwinklingStar.Add(new Star(curScreenSize, Invaders_Img[8]));
        }

        public void Twinkle()
        {
            TwinklingStar.Clear();
            for (int i=0 ; i<5 ; ++i)
            {
                TwinklingStar.Add(new Star(curScreenSize, Invaders_Img[8]));
            }            
        }
    }
}
