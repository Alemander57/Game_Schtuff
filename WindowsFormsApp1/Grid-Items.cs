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
        public int x, y, width, height, gridx, gridy, XPosition, YPosition;
        public Image Floor_Image;
        public Rectangle FloorRec;

        public Grid_Items(int gridx, int gridy, int InputX, int InputY)
        {
            XPosition = InputX;
            YPosition = InputY-((InputX -1)*10)+1;
            x = gridx;
            y = gridy;
            height = 50;
            width = 50;
            Floor_Image = Properties.Resources.Base_Grid_Item2;



        }
        public void DrawMap(Graphics g)
        {
            FloorRec = new Rectangle(x, y, width, height);
            g.DrawImage(Floor_Image, FloorRec);
        }
        
    }
}
