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

        ~Shot()
        {
            shooter.IncreaseAttackCount();
        }

        abstract public bool Move();
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
            if (curPlayerPos.X == curPos.X
                && curPlayerPos.Y == curPos.Y)
            {
                return true;
            }
            SetPos(curPos.X, curPos.Y - 10);
            return false;
        }

    }

    class PlayerShot : Shot
    {
        public PlayerShot(Point _pos, PictureBox picture, Mover _shooter)
        {
            shooter = _shooter;
            SetPos(_pos);
            shooter.DecreaseAttackCount();
            SettingPB(picture);
        }
        public override bool Move()
        {
            List<Invader> invaders = GameObject.Instance().GetEnemyList();
            Point curPos = GetPos();            
            for (int i=0; i<invaders.Count; ++i)
            {
                Point EnemyPos = invaders[i].GetPos();
                if (EnemyPos.X == curPos.X && EnemyPos.Y == curPos.Y)
                {
                    return true;
                }
            }
            SetPos(curPos.Y, curPos.Y + 10);
            return false;
        }
    }
}
