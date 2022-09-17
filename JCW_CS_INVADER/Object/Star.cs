using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JCW_CS_INVADER.Object
{
    class Star
    {
        public PictureBox MyPictureBox;
        private Random randomX;
        private Random randomY;
        private Point position;

        public Star(Rectangle size, PictureBox picture)
        {            
            randomX = new Random(Guid.NewGuid().GetHashCode());
            randomY = new Random(Guid.NewGuid().GetHashCode()+1);
            MyPictureBox = new PictureBox();
            SettingPB(picture);
            SetPos(randomX.Next(10, size.Width - 10)/10*10, randomY.Next(10, size.Height - 10) / 10 * 10);
        }
        public PictureBox GetPicture()
        {
            return MyPictureBox;
        }
        public void SetPos(int x, int y)
        {
            position.X = x;
            position.Y = y;
            MyPictureBox.Location = position;
        }

        protected void SettingPB(PictureBox picture)
        {
            MyPictureBox.Image = picture.Image;
            MyPictureBox.Size = picture.Size;
            MyPictureBox.SizeMode = picture.SizeMode;
            MyPictureBox.BackColor = picture.BackColor;
        }
    }
}
