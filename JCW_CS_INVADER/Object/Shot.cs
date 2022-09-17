using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JCW_CS_INVADER.Object
{
    abstract class Shot : Mover
    {
        protected Mover shooter;

        public Shot()
        {
            speed = 40;
        }
        abstract public bool Move();

        public bool Hit(Point _other)
        {
            if (_other.X - 15 < position.X && position.X < _other.X + 15
                && _other.Y - 15 < position.Y && position.Y < _other.Y + 15)
                return true;
            else
                return false;
        }
    }

    class EnemyShot : Shot
    {
        public EnemyShot(Point _pos, PictureBox picture, Mover _shooter)
        {
            shooter = _shooter;
            SetPos(_pos);
            shooter.DecreaseAttackCount();
            SettingPB(picture);
        }

        public override bool Move()
        {
            Point curPlayerPos = GameObject.Instance().GetPlayer().GetPos();
            Point curPos = GetPos();
            SetPos(curPos.X, curPos.Y + 10);
            if (curPos.Y > 420)
                return true;
            return false;
        }

    }

    class PlayerShot : Shot
    {
        public PlayerShot(Point _pos, PictureBox picture, Mover _shooter)
        {
            shooter = _shooter;
            SetPos(_pos);
            SettingPB(picture);
        }
        public override bool Move()
        {
            Point curPos = GetPos();                        
            SetPos(curPos.X, curPos.Y - 10);
            if (curPos.Y < 0)
                return true;
            return false;
        }
    }
}
