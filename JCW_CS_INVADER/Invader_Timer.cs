using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCW_CS_INVADER
{
    class Invader_Timer
    {
        double startTime = 0.0f;
        double curTime = 0.0f;

        public void TimerStart()
        {
            startTime = System.DateTime.Now.TimeOfDay.TotalMilliseconds;
            curTime = startTime;
        }

        public void TimerUpdate()
        {
            curTime = System.DateTime.Now.TimeOfDay.TotalMilliseconds - startTime;
        }

        public void TimerReset()
        {
            startTime = 0.0f;
            curTime = 0.0f;
        }

        public double GetCurTime()
        {
            return curTime == 0.0f? curTime+=0.001f : curTime;
        }
    }
}
