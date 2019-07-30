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
        public int EnemyX, EnemyY, x, y, width, height,UV;
        public Image EnemyImg;
        public Rectangle EnemyRec;

        public Enemy(int EnemyX,int EnemyY) //number one
        {
            x = (EnemyX-1)*50;
            y = (EnemyY-1)*50;
     
            width = 50;
            height = 50;
            EnemyImg = Properties.Resources.Alien;





        }
        public void DrawEnemy(Graphics g)
        {
            EnemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(EnemyImg, EnemyRec);
        }
    }
}
