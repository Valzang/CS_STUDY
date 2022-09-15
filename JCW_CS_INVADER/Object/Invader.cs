using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCW_CS_INVADER.Object
{
    abstract class Invader : Mover
    {
        protected float attackTime = 5.0f;
        protected int scorePoint = 0;

        public void GiveScore(Player _curPlayer)
        {
            _curPlayer.GetScore(scorePoint);
        }

        public void Attack()
        {
            double time = attackTimer.GetCurTime();
            if (time == 0.0f || time >= attackTime)
            {
                if (curAttackCount < totalAttackCount)
                {
                    GameObject.Instance().AddEnemyShot(GetPos());
                    ++curAttackCount;
                    attackTimer.TimerReset();
                    attackTimer.TimerStart();
                }
            }      
            attackTimer.TimerUpdate();            
        }
    }

    class Enemy_Star : Invader
    {
        public Enemy_Star(int _WaveCount, PictureBox _picture)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            scorePoint = 10;
            MyPictureBox = _picture;
        }
    }

    class Enemy_Spaceship : Invader
    {
        public Enemy_Spaceship(int _WaveCount, PictureBox _picture)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            scorePoint = 20;
            MyPictureBox = _picture;
        }
    }

    class Enemy_Saucer : Invader
    {
        public Enemy_Saucer(int _WaveCount, PictureBox _picture)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            scorePoint = 30;
            MyPictureBox = _picture;
        }
    }

    class Enemy_Bug : Invader
    {
        public Enemy_Bug(int _WaveCount, PictureBox _picture)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            scorePoint = 40;
            MyPictureBox = _picture;
        }
    }

    class Enemy_Satellite : Invader
    {
        public Enemy_Satellite(int _WaveCount, PictureBox _picture)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            scorePoint = 50;
            MyPictureBox = _picture;
        }
    }
}
