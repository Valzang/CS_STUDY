using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JCW_CS_INVADER.Object
{
    class GameObject
    {        
        List<Invader> InvadersList;
        Player curPlayer;
        List<Shot> Missile_Player;
        List<Shot> Missile_Invader;
        Star TwinklingStar;

        // 현재 화면 크기
        Rectangle curScreenSize;
        public void SetScreenSize(Rectangle _Val) { curScreenSize.Width = _Val.Width; curScreenSize.Height = _Val.Height; }

        int WaveCount = 0;

        public void Invader_Init() 
        { 
            InvadersList.Clear();             
            for (int i=0; i<5; ++i)
            {
                for (int j=0; j<6; ++j)
                {
                    switch(i)
                    {
                        case 0:
                            InvadersList.Add(new Enemy_Star());
                            break;
                        case 1:
                            InvadersList.Add(new Enemy_Spaceship());
                            break;
                        case 2:
                            InvadersList.Add(new Enemy_Saucer());
                            break;
                        case 3:
                            InvadersList.Add(new Enemy_Bug());
                            break;
                        case 4:
                            InvadersList.Add(new Enemy_Satellite());
                            break;
                    }
                }
            }
        }
    }
}
