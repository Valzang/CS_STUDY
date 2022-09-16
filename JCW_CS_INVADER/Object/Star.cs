using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JCW_CS_INVADER.Object
{
    class Star : Mover
    {
        private Random randomX;
        private Random randomY;
        public Star(Rectangle size, PictureBox picture)
        {            
            randomX = new Random(Guid.NewGuid().GetHashCode());
            randomY = new Random(Guid.NewGuid().GetHashCode()+1);
            SettingPB(picture);
            SetPos(randomX.Next(10, size.Width - 10)/10*10, randomY.Next(10, size.Height - 10) / 10 * 10);
        }
    }
}
