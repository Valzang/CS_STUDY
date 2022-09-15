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
    public partial class GameInvader : Form
    {
        public GameInvader()
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
            GameObject.Instance().SetImg(invadersImg);
        }                                                 
    }                        
}
