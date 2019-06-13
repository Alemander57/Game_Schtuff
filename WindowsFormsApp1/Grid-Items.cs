using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Grid_Items
    {
        private int x, y, width, height;
        private Image Floor_Image;
        private Rectangle FloorRec;

        public Grid_Items()
            {
            x = 0;
            y = 0;
            height = 50;
            width = 50;
            Floor_Image = Properties.Resources.Base_Grid_Item;
            FloorRec = new Rectangle(x, y, width, height);

        }
        public void DrawMap(Graphics g)
        {
            g.DrawImage(Floor_Image, FloorRec);
        }

    }
}
