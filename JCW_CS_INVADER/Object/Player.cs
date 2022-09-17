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
        public bool isDead = false;
        protected int speed = 10;

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

        public void SetImgPos()
        {
            MyPictureBox.Location = position;
        }

        public void SetPos(int _x, int _y)
        {            
            position.X = _x;
            position.Y = _y;
        }

        public void SetPos(Point _pos)
        {
            position.X = _pos.X;
            position.Y = _pos.Y;
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

        virtual public void GetDamage()
        {
            isDead = true;
        }

        public bool Dead()
        {
            return isDead;
        }

        virtual public void Move(Direction dir)
        {
            Point curPos = GetPos();
            switch(dir)
            {
                case Direction.Left:
                    SetPos(curPos.X - speed, curPos.Y);
                    break;
                case Direction.Right:
                    SetPos(curPos.X + speed, curPos.Y);
                    break;
                case Direction.Up:
                    SetPos(curPos.X, curPos.Y - speed);
                    break;
                case Direction.Down:
                    SetPos(curPos.X, curPos.Y + speed);
                    break;
            }
        }
    }

    //==========================================================================
    class Player : Mover
    {
        private int lifeCount = 2;
        private Point startPos;

        public Player(PictureBox picture, Rectangle _start)
        {
            startPos.X = _start.Width / 2;
            startPos.Y = _start.Height - 30;
            SettingPB(picture);
            RePos();
        }

        public void RePos()
        {
            SetPos(startPos);
        }
        public void Attack()
        {
            if (curAttackCount < totalAttackCount)
            {
                GameObject.Instance().AddPlayerShot(GetPos(), this);
                ++curAttackCount;
            }
        }

        override public void GetDamage()
        {
            --lifeCount;
            if (lifeCount < 0)
                isDead = true;
        }

        override public void Move(Direction dir)
        {
            Point curPos = GetPos();
            switch (dir)
            {
                case Direction.Left:
                    SetPos(curPos.X - 20, curPos.Y);
                    break;
                case Direction.Right:
                    SetPos(curPos.X + 20, curPos.Y);
                    break;
            }
        }
    }
}
