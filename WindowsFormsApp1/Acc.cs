using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Acc
    {
        public int x, y, width, height;
        public Image AccImg;
        public Rectangle AccRec;

        public Acc()
        {
            x = -122;
            y = -122;
            AccImg = Properties.Resources.Hit;
            width = 50;
            height = 25;

        }
        public void DrawAcc(Graphics g)
        {
            AccRec = new Rectangle(x, y, width, height);
            g.DrawImage(AccImg, AccRec);

        }
    }
}
