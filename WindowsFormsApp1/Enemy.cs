using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Enemy
    {
        public int EnemyX, EnemyY, x, y, width, height;
        public Image EnemyImg;
        public Rectangle EnemyRec;

        public Enemy() //number one
        {
            x = EnemyX;
            y = EnemyY;
            width = 50;
            height = 50;
            EnemyImg = Properties.Resources.Alien;





        }
        public void DrawPlayer(Graphics g)
        {
            EnemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(EnemyImg, EnemyRec);
        }
    }
}
