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

        public int GetScore()
        {
            return scorePoint;
        }

        public bool Attack()
        {
            double time = attackTimer.GetCurTime();
            bool Success = false;
            if (time == 0.0f || time >= attackTime)
            {
                if (curAttackCount < totalAttackCount)
                {
                    GameObject.Instance().AddEnemyShot(GetPos(), this);
                    ++curAttackCount;
                    attackTimer.TimerReset();
                    attackTimer.TimerStart();
                    Success = true;
                    time += 0.001f;
                }
            }      
            attackTimer.TimerUpdate();
            return Success;
        }

        protected void SetAttackDefault(int _WaveCount)
        {
            attackTime -= (0.2f * _WaveCount);
            totalAttackCount += _WaveCount;
            speed += (_WaveCount * 2);
        }
    }

    class Enemy_Star : Invader
    {
        public Enemy_Star(int _WaveCount, PictureBox picture)
        {
            SetAttackDefault(_WaveCount);
            scorePoint = 10;
            SettingPB(picture);
        }
    }

    class Enemy_Spaceship : Invader
    {
        public Enemy_Spaceship(int _WaveCount, PictureBox picture)
        {
            SetAttackDefault(_WaveCount);
            scorePoint = 20;
            SettingPB(picture);
        }
    }

    class Enemy_Saucer : Invader
    {
        public Enemy_Saucer(int _WaveCount, PictureBox picture)
        {
            SetAttackDefault(_WaveCount);
            scorePoint = 30;
            SettingPB(picture);
        }
    }

    class Enemy_Bug : Invader
    {
        public Enemy_Bug(int _WaveCount, PictureBox picture)
        {
            SetAttackDefault(_WaveCount);
            scorePoint = 40;
            SettingPB(picture);
        }
    }

    class Enemy_Satellite : Invader
    {
        public Enemy_Satellite(int _WaveCount, PictureBox picture)
        {
            SetAttackDefault(_WaveCount);
            scorePoint = 50;
            SettingPB(picture);
        }
    }
}
