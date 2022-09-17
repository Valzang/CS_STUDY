using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JCW_CS_INVADER.Object;

enum Direction
{
    Left,
    Right,
    Up,
    Down,
}

namespace JCW_CS_INVADER
{
    public partial class GameInvaders : Form
    {        
        List<PictureBox> invadersImg;
        List<Invader> invaderList;
        List<Shot> invaderShots;
        List<Shot> PlayerShots;
        Player curPlayer;
        List<Star> stars;

        List<Keys> keyPressed = new List<Keys>();
        int score = 0;
        Direction dir = Direction.Left;

        bool gameOver = false;
        public GameInvaders()
        {
            KeyPreview = true;
            InitializeComponent();
            GameObject.Instance().SetScreenSize(ClientRectangle);
            ImgAdd();
            GameObject.Instance().SetImg(invadersImg);

            GameObject.Instance().Invader_Init(invadersImg);
            List<Invader> invaders = GameObject.Instance().GetEnemyList();
            foreach(Invader invader in invaders)
            {
                Controls.Add(invader.GetPicture());
            }

            GameObject.Instance().Player_Init();
            Controls.Add(GameObject.Instance().GetPlayer().GetPicture());

            GameObject.Instance().Star_Init();

            curPlayer = GameObject.Instance().GetPlayer();
            invaderList = GameObject.Instance().GetEnemyList();
            invaderShots = GameObject.Instance().GetEnemyShots();
            PlayerShots = GameObject.Instance().GetPlayerShots();
            stars = GameObject.Instance().GetStars();

            this.KeyDown += new KeyEventHandler(GameInvaders_KeyDown);
            this.KeyUp += new KeyEventHandler(GameInvaders_KeyUp);
            
        }       

        // 로직
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // 플레이어 죽었는지 체크
            if (curPlayer.Dead())
            { 
                gameOver = true;
                // 임시로 종료
                Application.Exit();
                return;
            }
            // 탄 / 적 / 플레이어 움직임
            Move_Object();
           
            // 탄에 맞았는지 체크
            Hit();

        }

        // 애니메이션
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Twinkle();
            GameObject.Instance().Animation_Update();

        }
        private void Move_Object()
        {
            // 탄 움직임===================================================
            for (int i= invaderShots.Count() - 1; i>=0; --i)
            {
                if(invaderShots[i].Move())
                {
                    this.Controls.Remove(invaderShots[i].MyPictureBox);
                    invaderShots.RemoveAt(i);
                }
            }
            for (int i = PlayerShots.Count() - 1; i >= 0; --i)
            {
                if (PlayerShots[i].Move())
                {
                    this.Controls.Remove(PlayerShots[i].MyPictureBox);
                    PlayerShots.RemoveAt(i);
                    curPlayer.DecreaseAttackCount();
                }
            }

            // 적 움직임===================================================
            bool breakDir = false;
            foreach (Invader invader in invaderList)
            {
                if (invader.GetPos().Y > 420)
                {
                    gameOver = true;
                    return;
                }
                else if (breakDir)
                    break;
                else
                {
                    switch (dir)
                    {
                        case Direction.Left:
                            if (invader.GetPos().X <= 170)
                            {
                                invader.SetPos(170, invader.GetPos().Y);
                                dir = Direction.Down;
                                breakDir = true;
                            }
                            break;
                        case Direction.Right:
                            if (invader.GetPos().X >= 630)
                            {
                                invader.SetPos(630, invader.GetPos().Y);
                                dir = Direction.Down;
                                breakDir = true;
                            }
                            break;
                        case Direction.Down:
                            if (invader.GetPos().X >= 630)
                            {
                                dir = Direction.Left;
                                breakDir = true;
                            }
                            else
                            {
                                dir = Direction.Right;
                                breakDir = true;
                            }
                            break;
                    }
                }
            }

            foreach (Invader invader in invaderList)
            {
                invader.Move(dir);
            }

            // 플레이어 움직임
            foreach (Keys key in keyPressed)
            {
                if (key == Keys.Left)
                {
                    if (curPlayer.GetPos().X <= 160)
                        curPlayer.SetPos(160, curPlayer.GetPos().Y);
                    else
                        curPlayer.Move(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    if (curPlayer.GetPos().X >= 640)
                        curPlayer.SetPos(640, curPlayer.GetPos().Y);
                    else
                        curPlayer.Move(Direction.Right);
                    return;
                }
            }
        }

        private void Hit()
        {

            //플레이어 탄환에 맞은 적
            for (int i = PlayerShots.Count() - 1; i >= 0; --i)
            {
                for (int j = invaderList.Count() - 1; j >= 0; --j)
                {
                    if (PlayerShots[i].Hit(invaderList[j].GetPos()))
                    {
                        this.Controls.Remove(invaderList[j].MyPictureBox);
                        score += invaderList[j].GetScore();
                        invaderList.RemoveAt(j);
                        this.Controls.Remove(PlayerShots[i].MyPictureBox);
                        PlayerShots.RemoveAt(i);
                        curPlayer.DecreaseAttackCount();
                        break;
                    }
                }
            }

            //적 탄환에 맞은 플레이어.
            for (int i = invaderShots.Count() - 1; i >= 0; --i)
            {
                if (invaderShots[i].Hit(curPlayer.GetPos()))
                {
                    curPlayer.GetDamage();
                    this.Controls.Remove(invaderShots[i].MyPictureBox);
                    invaderShots.RemoveAt(i);
                    break;
                }
            }
        }
        
        private void Twinkle()
        {
            // 랜덤한 별 5개 삭제
            for (int i = 0; i < 5; ++i)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                int temp = r.Next(0, 95);
                this.Controls.Remove(stars[temp].MyPictureBox);
                stars.RemoveAt(temp);
            }

            // 별 5개 추가
            for (int i = 0; i < 5; ++i)
            {
                stars.Add(new Star(ClientRectangle, pictureBox_TwinklingStar));
                this.Controls.Add(stars[stars.Count() - 1].MyPictureBox);
            }
        }

        private void ImgAdd()
        {
            invadersImg = new List<PictureBox>();
            invadersImg.Add(pictureBox_EnemyStar);
            invadersImg.Add(pictureBox_EnemySpaceship);
            invadersImg.Add(pictureBox_EnemySaucer);
            invadersImg.Add(pictureBox_EnemyBugs);
            invadersImg.Add(pictureBox_EnemySatellite);
            invadersImg.Add(pictureBox_Player);
            invadersImg.Add(pictureBox_PlayerShot);
            invadersImg.Add(pictureBox_EnemyShot);
            invadersImg.Add(pictureBox_TwinklingStar);            
        }
        void GameInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();
            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {

                }
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (PlayerShots.Count() != 2)
                {
                    curPlayer.Attack();
                    this.Controls.Add(PlayerShots[PlayerShots.Count() - 1].GetPicture());
                    return;
                }                
            }
            // 탄 발사
            if (keyPressed.Contains(e.KeyCode))
                keyPressed.Remove(e.KeyCode);
            keyPressed.Add(e.KeyCode);
        }
        void GameInvaders_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyPressed.Contains(e.KeyCode))
                keyPressed.Remove(e.KeyCode);

        }
        /*
        // 키 2개 동시입력은 안됨
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Point curPlayerPos = GameObject.Instance().GetPlayer().GetPos();
            switch (keyData)
            {
                case Keys.Left:
                    GameObject.Instance().GetPlayer().SetPos(curPlayerPos.X - 5, curPlayerPos.Y);
                    return true;
                case Keys.Right:
                    GameObject.Instance().GetPlayer().SetPos(curPlayerPos.X + 5, curPlayerPos.Y);
                    return true;
            }
            switch (keyData)
            {
                case Keys.Up:
                    GameObject.Instance().GetPlayer().SetPos(curPlayerPos.X, curPlayerPos.Y - 5);
                    return true;
                case Keys.Down:
                    GameObject.Instance().GetPlayer().SetPos(curPlayerPos.X, curPlayerPos.Y + 5);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        */
    }                        
}
