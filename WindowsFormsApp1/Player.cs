using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Player
    {
       public int PlayerX, PlayerY,x,y,width, height,HP ;
        public Image PlayerImg;
        public Rectangle PlayerRec;

        public Player()
        {
            HP = 10;
            x = PlayerX;
            y = PlayerY;
            width = 50;
            height = 50;
            PlayerImg = Properties.Resources.Player;
           




        }
        public void DrawPlayer(Graphics g)
        {
            PlayerRec = new Rectangle(x, y, width, height);
            g.DrawImage(PlayerImg, PlayerRec);
        }
    }
}
