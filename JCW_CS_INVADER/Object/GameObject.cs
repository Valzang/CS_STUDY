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
        int WaveCount = 0;

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

        // 탄 관련
        public List<Shot> GetEnemyShots()
        {
            return Missile_Invader;
        }
        public List<Shot> GetPlayerShots()
        {
            return Missile_Player;
        }
        

        public void AddEnemyShot(Point _enemyPos, Mover _shooter)
        {
            Missile_Invader.Add(new EnemyShot(_enemyPos, Invaders_Img[7], _shooter));
        }
        public void AddPlayerShot(Point _playerPos, Mover _shooter)
        {
            Missile_Player.Add(new PlayerShot(_playerPos, Invaders_Img[6], _shooter));
        }

        //========================================================

        public List<Star> GetStars()
        {
            return TwinklingStar;
        }

        // Mover 가져오기
        public Player GetPlayer()
        {
            return curPlayer;
        }
        public List<Invader> GetEnemyList()
        {
            return InvadersList;
        }

        public void Animation_Update()
        {
            curPlayer.SetImgPos();
            foreach (Shot shot in Missile_Player)
                shot.SetImgPos();
            foreach (Shot shot in Missile_Invader)
                shot.SetImgPos();
            foreach (Invader invader in InvadersList)
                invader.SetImgPos();
        }

        public void Clear()
        {
            Invaders_Img.Clear();
            InvadersList.Clear();
            Missile_Invader.Clear();
            WaveCount = 0;
            TwinklingStar.Clear();
            curPlayer = null;
            Missile_Player.Clear();

        }

        public void Invader_Init(List<PictureBox> _Img, int _wave) 
        {
            Invaders_Img = _Img;
            WaveCount = _wave;       
            for (int i=0; i<5; ++i)
            {
                for (int j=0; j<5; ++j)
                {
                    switch(i)
                    {
                        case 0:
                            InvadersList.Add(new Enemy_Star(WaveCount, Invaders_Img[i]));
                            InvadersList[j].SetPos(630 - 50 * j, 200 );
                            break;
                        case 1:
                            InvadersList.Add(new Enemy_Spaceship(WaveCount, Invaders_Img[i]));
                            InvadersList[5 + j].SetPos(630 - 50 * j, 150);
                            break;
                        case 2:
                            InvadersList.Add(new Enemy_Saucer(WaveCount, Invaders_Img[i]));
                            InvadersList[10 + j].SetPos(630 - 50 * j, 100);
                            break;
                        case 3:
                            InvadersList.Add(new Enemy_Bug(WaveCount, Invaders_Img[i]));
                            InvadersList[15 + j].SetPos(630 - 50 * j, 50);
                            break;
                        case 4:
                            InvadersList.Add(new Enemy_Satellite(WaveCount, Invaders_Img[i]));
                            InvadersList[20 + j].SetPos(630 - 50 * j, 0);
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
    }
}
