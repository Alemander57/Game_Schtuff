﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        
        int Xposition =0, Yposition = 0, MousePosX,MousePosY,PlayerPosX,PlayerPosY,EnPosX=4,EnPosY=5,UV;
        bool CanMove, CanShoot, ShootOrMove;
        Random rnd = new Random();
                
       BindingList<Grid_Items> floor  = new BindingList<Grid_Items>();
        Player player = new Player();
        List<Enemy> enemy = new List<Enemy>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < (this.Width / 50); i++)
            {
                int gridx = (i * 50);
                Xposition++;
                for (int l = 0; l < (this.Height / 50); l++)
                {
                    int gridy = (l * 50);
                    floor.Add(new Grid_Items((gridx), (gridy), (Xposition), (Yposition)));
                    Yposition++;
                }
            }

            for (int a = 0; a < 4 ; a++)
            {
                EnPosX++;
                EnPosY++;
                UV++;
                enemy.Add(new Enemy(EnPosX, EnPosY, UV));
            }
            

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
           
            foreach (Grid_Items f in floor)
            {
                f.DrawMap(g);
            }
            foreach(Enemy b in enemy)
            {
                b.DrawEnemy(g);
            }
            player.DrawPlayer(g);
           

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            foreach (Enemy b in enemy)
            {
               // b.x = (b.EnemyX - 1) * 50;
                //b.y = (b.EnemyY - 1) * 50;
            }
            foreach (Grid_Items f in floor)
            {
               
            }



        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           // floor.Clear();
           // for (int i = 0; i < ((this.Width / 50)+1); i++)
           // {
                
           //     int gridx = (i * 50);
            //    for (int l = 0; l < ((this.Height / 50)+1); l++)
           //     {
          //          int gridy = (l * 50);
          //          floor.Add(new Grid_Items((gridx), (gridy)));
           //     }
           // }
      }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Enemy b in enemy)
            {
                if (CanMove == true | CanShoot == true)
                {
                    if ((b.EnemyX) - player.PlayerX < 0)
                    {
                        b.EnemyX = rnd.Next(b.EnemyX+1,b.EnemyX+3);
                    }
                    else if ((b.EnemyX) - player.PlayerX > 0)
                    {
                        b.EnemyX = 10 - rnd.Next(b.EnemyX+1,b.EnemyX+3) ;
                    }

                    if ((b.EnemyY) - player.PlayerY < 0)
                    {
                        b.EnemyY = rnd.Next(b.EnemyY+1,b.EnemyY+3);
                    }
                    else if ((b.EnemyY) - player.PlayerY > 0)
                    {
                        b.EnemyY = 10 - rnd.Next(b.EnemyY+1,b.EnemyY+3);
                    }
                    //if(b.EnemyX < 1)
                    //{ b.EnemyX = 1; }

                    //if (b.EnemyX > 10)
                    //{ b.EnemyX = 10; }

                    //if (b.EnemyY < 1)
                    //{ b.EnemyY = 1; }

                    //if (b.EnemyY > 10)
                    //{ b.EnemyY = 10; }

                    b.y = (b.EnemyY - 1) * 50;
                    b.x = (b.EnemyX - 1) * 50;
                }
               
            }

            foreach (Grid_Items f in floor)
            {


                   foreach(Enemy b in enemy)
                   {
                    if (b.EnemyRec.IntersectsWith(f.FloorRec))
                    {
                        b.EnemyX = f.XPosition;
                        b.EnemyY = f.YPosition;
                    }
                   }
                if (CanMove == true)
                {
                    if (f.FloorRec.Contains(e.Location))
                    {
                        player.PlayerX = f.XPosition;
                        player.PlayerY = f.YPosition;
                        player.y = (player.PlayerY - 1) * 50;
                        player.x = (player.PlayerX - 1) * 50;


                    }
                    
                    
                }
            }


            foreach (Enemy b in enemy)
            {
                if (b.EnemyRec.Contains(e.Location))
                {
                    EnXDisp.Text = b.EnemyX.ToString();
                    //YPosBox.Text = b.YPosition.ToString();
                }



                //    if ((b.EnemyX) - player.PlayerX < 0)
                //    {
                //        b.EnemyX++;
                //    }
                //    else if ((b.EnemyX) - player.PlayerX > 0)
                //    {
                //        b.EnemyX--;
                //    }
                //    if ((b.EnemyY) - player.PlayerY < 0)
                //    {
                //        b.EnemyY++;
                //    }
                //    else if ((b.EnemyY) - player.PlayerY > 0)
                //    {
                //        b.EnemyY--;
            }



            //}






        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            GridReset.Enabled = false;
            //gets rid of highlights and then disables until another square is highlighted
        }
      

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            // (f.XPosition - 1) * 50 < player.x
            

            foreach (Grid_Items f in floor)
            {
                if (f.FloorRec.Contains(e.Location))
                    {
                    XPosBox.Text = f.XPosition.ToString();
                    YPosBox.Text = f.YPosition.ToString();
                    MousePosX = f.XPosition;
                    MousePosY = f.YPosition;
                }

                if (f.FloorRec.Contains(e.Location) && f.FloorRec.IntersectsWith(player.PlayerRec))
                {
                    f.Floor_Image = Properties.Resources.Base_Grid_Item2;
                    CanMove = false;

                }
                else if (f.FloorRec.Contains(e.Location) && (MousePosX - player.PlayerX) <= 3 && (MousePosX - player.PlayerX) >= -3
                     && (MousePosY - player.PlayerY) <= 3 && (MousePosY - player.PlayerY) >= -3)
                {
                    f.Floor_Image = Properties.Resources.Grid_ItemH;
                    CanMove = true;
                }
                else if (f.FloorRec.Contains(e.Location))
                {
                    f.Floor_Image = Properties.Resources.Grid_ItemN;
                    CanMove = false;
                }
                else
                {
                  f.Floor_Image = Properties.Resources.Base_Grid_Item2;
                }

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
