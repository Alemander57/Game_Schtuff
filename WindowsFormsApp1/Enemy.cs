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
        public int EnemyPosX, EnemyPosY, x, y, width, height,SavePosX,SavePosY,HP,MaxHP;
        public double DAP,ADAP;
        public bool Marked;
        public Image EnemyImg;
        public Rectangle EnemyRec,RedHealth,GreenHealth;

        public Enemy(int EnemyX,int EnemyY) //number one
        {
            EnemyPosX = EnemyX;
            EnemyPosY = EnemyY;
            x = (EnemyX-1)*50;
            y = (EnemyY-1)*50;
            HP = 3;
            Marked = false;
            width = 50;
            height = 50;
            EnemyImg = Properties.Resources.Alien;
            DAP = 5;
            ADAP = 5;





        }
        public void DrawEnemy(Graphics g)
        {
            EnemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(EnemyImg, EnemyRec);
        }
    }
}
