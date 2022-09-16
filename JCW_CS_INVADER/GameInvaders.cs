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

namespace JCW_CS_INVADER
{
    public partial class GameInvaders : Form
    {
        int twinkle_count = -1;
        public GameInvaders()
        {            
            InitializeComponent();
            GameObject.Instance().SetScreenSize(ClientRectangle);

            List<PictureBox> invadersImg = new List<PictureBox>();
            invadersImg.Add(pictureBox_EnemyStar);
            invadersImg.Add(pictureBox_EnemySpaceship);
            invadersImg.Add(pictureBox_EnemySaucer);
            invadersImg.Add(pictureBox_EnemyBugs);
            invadersImg.Add(pictureBox_EnemySatellite);
            invadersImg.Add(pictureBox_Player);
            invadersImg.Add(pictureBox_PlayerShot);
            invadersImg.Add(pictureBox_EnemyShot);
            invadersImg.Add(pictureBox_TwinklingStar);
            GameObject.Instance().SetImg(invadersImg);
            GameObject.Instance().Player_Init();
            Controls.Add(GameObject.Instance().GetPlayer().GetPicture());
            //GameObject.Instance().Star_Init();
        }

        private void StarManage()
        {
            ++twinkle_count;
            if (twinkle_count != 0)
            {
                if (twinkle_count == 3)
                    twinkle_count = -1;
                return;
            }
            List<Star> stars = GameObject.Instance().GetStars();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0 ; i < stars.Count ; ++i)
                this.Controls.Remove(stars[i].MyPictureBox);
            //this.Controls.Remove(stars[r.Next(0,100)].MyPictureBox);

            GameObject.Instance().Twinkle();
            for (int i = 0 ; i < stars.Count ; ++i)
                this.Controls.Add(stars[i].MyPictureBox);
        }

        // 로직
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            StarManage();
        }

        // 애니메이션
        private void animationTimer_Tick(object sender, EventArgs e)
        {

        }

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
    }                        
}
