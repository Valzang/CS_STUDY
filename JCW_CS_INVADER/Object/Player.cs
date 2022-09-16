using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JCW_CS_INVADER.Object
{
    abstract class Mover
    {
        public PictureBox MyPictureBox;
        protected Point position;

        public Mover()
        {
            MyPictureBox = new PictureBox();            
        }        

        protected int curAttackCount = 0;
        protected int totalAttackCount = 2;

        protected Invader_Timer attackTimer = new Invader_Timer();

        public PictureBox GetPicture()
        {
            return MyPictureBox;
        }

        public void SetPos(int _x, int _y)
        {            
            position.X = _x;
            position.Y = _y;
            MyPictureBox.Location = position;
        }

        public void SetPos(Point _pos)
        {
            position.X = _pos.X;
            position.Y = _pos.Y;
            MyPictureBox.Location = position;
        }

        public Point GetPos()
        {
            return position;
        }
        public void DecreaseAttackCount()
        {
            --curAttackCount;
        }

        public void IncreaseAttackCount()
        {
            ++curAttackCount;
        }

        protected void SettingPB(PictureBox picture)
        {
            MyPictureBox.Image = picture.Image;
            MyPictureBox.Size = picture.Size;
            MyPictureBox.SizeMode = picture.SizeMode;
            MyPictureBox.BackColor = picture.BackColor;
        }
    }

    //==========================================================================
    class Player : Mover
    {
        private int lifeCount = 2;
        private int score = 0;
        private Point startPos;

        public Player(PictureBox picture, Rectangle _start)
        {
            startPos.X = _start.Width / 2;
            startPos.Y = _start.Height - 10;
            SettingPB(picture);
            RePos();
        }

        public void RePos()
        {
            SetPos(startPos);
        }
        public void SetLife(int _count)
        {
            lifeCount = _count;
        }

        public void Attack()
        {
            if (curAttackCount < totalAttackCount)
            {
                GameObject.Instance().AddEnemyShot(GetPos(), this);
                ++curAttackCount;
            }
        }

        public void GetScore(int _point)
        {
            score += _point;
        }
    }
}
