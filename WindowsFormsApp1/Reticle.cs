using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Reticle
    {
        public int x,y,width,height;
        public Image RetImg;
        public Rectangle RetRec;

        public Reticle()
        {
            x = 0;
            y = 0;
            RetImg = Properties.Resources.Reticle2;
            width = 40;
            height = 40;

        }

        public void DrawReticle(Graphics g)
        {
            RetRec = new Rectangle(x, y, width, height);
                g.DrawImage(RetImg, RetRec);

        }
    }

    
}
