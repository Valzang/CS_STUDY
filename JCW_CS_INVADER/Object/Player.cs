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
        

        protected int curAttackCount = 0;
        protected int totalAttackCount = 2;

        protected Timer attackTimer = new Timer();

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
    }
    class Player : Mover
    {
        private int lifeCount = 2;
        private int score = 0;

        public Player(PictureBox picture)
        {
            MyPictureBox = picture;
        }
        public void SetLife(int _count)
        {
            lifeCount = _count;
        }

        public void Attack()
        {
            if (curAttackCount < totalAttackCount)
            {
                GameObject.Instance().AddEnemyShot(GetPos());
                ++curAttackCount;
            }
        }

        public void GetScore(int _point)
        {
            score += _point;
        }
    }
}
