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
        private int x, y, width, height, gridx, gridy;
        private Image Floor_Image;
        private Rectangle FloorRec;

        public Grid_Items(int gridx, int gridy)
        {
            x = gridx;
            y = gridy;
            height = 50;
            width = 50;
            Floor_Image = Properties.Resources.Base_Grid_Item;



        }
        public void DrawMap(Graphics g)
        {
            FloorRec = new Rectangle(x, y, width, height);
            g.DrawImage(Floor_Image, FloorRec);
        }
        public int changesx
        {
            set
            {
                x = value;
                y = value;
            }
        }
    }
}
