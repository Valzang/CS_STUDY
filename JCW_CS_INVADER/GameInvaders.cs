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
        Label scoreLabel;
        Label scoreTitle;
        List<PictureBox> playerLife = new List<PictureBox>();
        int lifeCount;

        int moveCount = 0;
        int waveCount = 0;
        Label gameOverTitle;
        Label gameOverDesc;

        List<Keys> keyPressed = new List<Keys>();
        int score = 0;
        Direction dir = Direction.Left;

        bool gameOver = false;
        public GameInvaders()
        {
            KeyPreview = true;
            InitializeComponent();
            GameObject.Instance().SetScreenSize(ClientRectangle);
            scoreTitle = Label_ScoreTitle;
            scoreLabel = Label_ScorePoint;

            SetStart();

        }       

        // 로직
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // 플레이어 죽었는지 체크
            if (curPlayer.Dead())
            { 
                gameOver = true;
                // 임시로 종료
                Invalidate();
                gameOverTitle.Visible = true;
                gameOverDesc.Visible = true;
                animationTimer.Stop();
                gameTimer.Stop();
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
                    invaderShots[i].GetShooter().DecreaseAttackCount();
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
                            else if (invader.GetPos().X <= 170)
                            {
                                dir = Direction.Right;
                                breakDir = true;
                            }
                            break;
                    }
                }
            }

            int invaderCount = invaderList.Count();
            if (invaderCount != 0)
            {
                if (moveCount >= invaderCount)
                    moveCount = 0;

                invaderList[moveCount++].Move(dir);

                if(invaderCount <= 5)
                {
                    for (int i = 0; i < invaderCount; ++i)
                    {
                        if(invaderList[i].Attack())
                            this.Controls.Add(invaderShots[invaderShots.Count() - 1].GetPicture());
                    }
                }
                else
                {
                    for (int i = 0; i < 5; ++i)
                    {
                        if(invaderList[i].Attack())
                            this.Controls.Add(invaderShots[invaderShots.Count() - 1].GetPicture());
                    }
                }
            }
            
            //foreach (Invader invader in invaderList) // 렉걸림
            //{
            //    invader.Move(dir);
            //}

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
            if (invaderList.Count() == 0)
                InvaderWave();
            //플레이어 탄환에 맞은 적
            for (int i = PlayerShots.Count() - 1; i >= 0; --i)
            {
                for (int j = invaderList.Count() - 1; j >= 0; --j)
                {
                    if (PlayerShots[i].Hit(invaderList[j].GetPos()))
                    {
                        this.Controls.Remove(invaderList[j].MyPictureBox);
                        score += invaderList[j].GetScore();
                        scoreLabel.Text = score.ToString();
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
                    invaderShots[i].GetShooter().DecreaseAttackCount();
                    invaderShots.RemoveAt(i);
                    if(lifeCount>0)
                    {
                        this.Controls.Remove(playerLife[--lifeCount]);
                        playerLife.RemoveAt(lifeCount);
                    }                    
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

        private void InvaderWave()
        {
            GameObject.Instance().Invader_Init(invadersImg, waveCount++);
            invaderList = GameObject.Instance().GetEnemyList();
            foreach (Invader invader in invaderList)
            {
                Controls.Add(invader.GetPicture());
            }
        }
        private void Replay()
        {
            Controls.Clear();
            
            this.Update();
            GameObject.Instance().Clear();
            playerLife.Clear();
            keyPressed.Clear();           

            moveCount = 0;
            waveCount = 0;
            score = 0;
            dir = Direction.Left;

            gameOver = false;
            SetStart();
            animationTimer.Start();
            gameTimer.Start();
        }
        private void SetStart()
        {
            ImgAdd();
            GameObject.Instance().SetImg(invadersImg);

            this.Controls.Add(scoreTitle);
            this.Controls.Add(scoreLabel);

            gameOverTitle = Label_GameOver;
            gameOverDesc = Label_OverInfo;
            this.Controls.Add(Label_GameOver);
            this.Controls.Add(Label_OverInfo);

            gameOverTitle.Visible = false;
            gameOverDesc.Visible = false;

            InvaderWave();

            GameObject.Instance().Player_Init();
            Controls.Add(GameObject.Instance().GetPlayer().GetPicture());
            GameObject.Instance().Star_Init();

            // 플레이어
            curPlayer = GameObject.Instance().GetPlayer();
            lifeCount = curPlayer.GetLifecount();
            playerLife.Add(pictureBox_PlayerLife1);
            playerLife.Add(pictureBox_PlayerLife2);
            this.Controls.Add(playerLife[0]);
            this.Controls.Add(playerLife[1]);

            // 샷 추가
            invaderShots = GameObject.Instance().GetEnemyShots();
            PlayerShots = GameObject.Instance().GetPlayerShots();

            // 별
            stars = GameObject.Instance().GetStars();


            this.KeyDown += new KeyEventHandler(GameInvaders_KeyDown);
            this.KeyUp += new KeyEventHandler(GameInvaders_KeyUp);
        }
        void GameInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();
            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {
                    Replay();
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
    }                        
}
