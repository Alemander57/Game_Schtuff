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
    public partial class MainGmeFrm : Form
    {
        Graphics g;

        public int Xposition = 0, Yposition = 0, MousePosX, MousePosY, PlayerPosX, PlayerPosY, EnPosX = 4, EnPosY = 5, UV,
            AddEnemyC;
        public static int Test,AccDiff, Score;
        public static bool Tutorial = false;
        bool CanMove = true, CanShoot = false, ShootOrMove = false;
        Random rnd = new Random();

        BindingList<Grid_Items> floor = new BindingList<Grid_Items>();
        Player player = new Player();
        Acc acc = new Acc();
        List<Enemy> enemy = new List<Enemy>();
        Reticle reticle = new Reticle();

        private void DID_Tick(object sender, EventArgs e)
        {
            foreach (Enemy b in enemy)
            {
                if (b.Marked == true)
                {
                    acc.x = b.x;
                    acc.y = b.y;  //this puts the "hit" or "miss" Icon where the enemy is or was
                    if (Accuracy.EndScore > 7)
                    {
                        player.HP++;
                        Score++;
                        acc.AccImg = Properties.Resources.Hit;
                        enemy.Remove(b);
                        break; //removes an enemy from the map
                    }
                    if (Accuracy.EndScore < 8)
                    {
                        acc.AccImg = Properties.Resources.Miss;
                        b.Marked = false;
                    }
                }
            }
            DID.Enabled = false;
            MoveAnimation.Enabled = true;
            Accuracy.EndScore = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stay out of the range of the aliens (3 squares) while weaving in to make you own attacks");
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            for (int i = 0; i < (10); i++)
            {
                int gridx = (i * 50);
                Xposition++;
                for (int l = 0; l < (10); l++)
                {   //Makes Grid squares based on window size
                    int gridy = (l * 50);
                    floor.Add(new Grid_Items((gridx), (gridy), (Xposition), (Yposition)));
                    Yposition++;
                }
            }
            //starts the game and draws up the grid and enemies
            for (int a = 0; a < 4; a++)
            {
                EnPosX++;
                EnPosY++;
                UV++;
                enemy.Add(new Enemy(EnPosX, EnPosY));
            }

            foreach (Grid_Items f in floor)
            {
                if (player.PlayerRec.IntersectsWith(f.FloorRec))
                {
                    player.PlayerX = f.XPosition;
                    player.PlayerY = f.YPosition;
                }
                foreach (Enemy b in enemy)
                {   //links the values for player grid location to the grid
                    if (b.EnemyRec.IntersectsWith(f.FloorRec))
                    {
                        b.EnemyPosX = f.XPosition;
                        b.EnemyPosY = f.YPosition;
                    }
                    b.SavePosX = b.EnemyPosX;
                    b.SavePosY = b.EnemyPosY;

                }
            }
            player.PlayerY = 1;
            player.PlayerX = 1;
        }
        public MainGmeFrm()
        {
            InitializeComponent();
            reticle.x = -40;
            reticle.y = -40;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Z)
            {
                 ShootOrMove = true;
                 
            }
            if (e.KeyCode == Keys.X)
            {
                ShootOrMove = false;
                reticle.x = -40;
                reticle.y = -40;

            }

        
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //get the graphics used to paint on the panel control
            g = e.Graphics;
         
           
            foreach (Grid_Items f in floor)
            {
                f.DrawMap(g);
            }
            foreach(Enemy b in enemy)
            {
                b.DrawEnemy(g);
            }
            player.DrawPlayer(g);
            acc.DrawAcc(g);
            reticle.DrawReticle(g);
            //draws all the things where they should be

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //game doesn't super rely on a timer as it's turn based, just checking if enemies can shoot the player or whether the player is in shoot or move mode
            this.Invalidate();
            if(Accuracy.DID == 1)
            {
                DID.Enabled = true;
                Accuracy.DID = 0;
            }
            foreach (Enemy b in enemy)
            {
              
                b.ADAP = (Math.Sqrt(Math.Pow((double)b.EnemyPosX - (double)player.PlayerX, 2) + Math.Pow((double)b.EnemyPosY - (double)player.PlayerY, 2)));

            }
            if (ShootOrMove == false)
            {
                CanShoot = false;
            }
            if (ShootOrMove == true)
            {
                CanMove = false;
                
            }
            foreach (Grid_Items f in floor)
            {
               
            }
            AAScore.Text = Score.ToString();
            HP.Text = player.HP.ToString();


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveAnimation.Enabled = true;
          
            if (player.HP >10)
            {
                player.HP = 10;
            }
            acc.x = -100;
            acc.y = -100;//moves hit or miss icons off the screen
            if (AddEnemyC == 5)
            {//adds a new enemy after 5 turns
                enemy.Add(new Enemy((rnd.Next(1, 11)), (rnd.Next(1, 11))));
                AddEnemyC = 0;
                
            }
            foreach (Grid_Items f in floor)
            {


               
                if (CanShoot == true && CanMove == false)
                {
                   
                    foreach (Enemy b in enemy)
                        {
                            if (b.EnemyRec.IntersectsWith(f.FloorRec) && f.FloorRec.Contains(e.Location))
                            {
                            AddEnemyC++; // adds to the new enemy counter
                            b.Marked = true;
                               Accuracy a = new Accuracy();
                              a.Show();
                            MoveAnimation.Enabled = false;
                            //opens accuracy minigame
                               
                            }
                        }
                    
                }
                if (CanMove == true & CanShoot == false)
                {
                    if (f.FloorRec.Contains(e.Location))
                    {//tells the timer where the player should be
                        AddEnemyC++;
                        player.PlayerX = f.XPosition;
                        player.PlayerY = f.YPosition;


                    }


                }
            }
            if (CanMove == true | CanShoot == true)
            {
               
                foreach (Enemy b in enemy) // b for bad
            {
                
              
                 
                    if ( b.DAP <= 3&& b.Marked != true)
                    {
                        player.HP--;
                    }

                    if (b.DAP > 3)
                    {
                        if ((b.EnemyPosX) - player.PlayerX < 0)
                        {
                            b.EnemyPosX = rnd.Next(b.EnemyPosX + 0, b.EnemyPosX + 3);
                        }
                        else if ((b.EnemyPosX) - player.PlayerX > 0)
                        {
                            b.EnemyPosX = b.EnemyPosX - rnd.Next(0, 3);
                        }

                        if ((b.EnemyPosY) - player.PlayerY < 0)
                        {
                            b.EnemyPosY = rnd.Next(b.EnemyPosY + 0, b.EnemyPosY + 3);
                        }
                        else if ((b.EnemyPosY) - player.PlayerY > 0)
                        {
                            b.EnemyPosY = b.EnemyPosY - rnd.Next(0, 3);
                        }

                        foreach (Enemy eb in enemy) // eb for "Extra Bad"
                        {
                            if (b.EnemyPosX == eb.EnemyPosX && b.EnemyPosY == eb.EnemyPosY)
                            {

                                if (b.EnemyPosX > b.SavePosX)
                                {
                                    b.EnemyPosX -= 1;
                                }
                                else if ((b.EnemyPosX) < b.SavePosX)
                                {
                                    b.EnemyPosX += 1;
                                }

                                if (b.EnemyPosY < b.SavePosY)
                                {
                                    b.EnemyPosY += 1;
                                }
                                else if ((b.EnemyPosY) > b.SavePosY)
                                {
                                    b.EnemyPosY -= 1;
                                }
                            }
                        }


                        if (b.EnemyPosX < 1)
                        { b.EnemyPosX = 1; }

                        if (b.EnemyPosX > 10)
                        { b.EnemyPosX = 10; }

                        if (b.EnemyPosY < 1)
                        { b.EnemyPosY = 1; }

                        if (b.EnemyPosY > 10)
                        { b.EnemyPosY = 10; }

                        ShootOrMove = false;
                        // MoveAnimation.Enabled = true;
                        b.SavePosX = b.EnemyPosX;
                        b.SavePosY = b.EnemyPosY;
                       
                    }
                    b.DAP = (Math.Sqrt(Math.Pow((double)b.EnemyPosX - (double)player.PlayerX, 2) + Math.Pow((double)b.EnemyPosY - (double)player.PlayerY, 2)));
                }
               
            }
            if (player.HP <= 0)
            {
                ScoreSet s = new ScoreSet();
                s.Show();
                MainTimer.Enabled = false;
                this.Hide();
                //sets the players score and ends the game
            }

            
        }
        private void MoveAnimation_Tick(object sender, EventArgs e)
        {
            
            foreach (Enemy b in enemy)
            {
                if (b.x < (b.EnemyPosX - 1) * 50 )
                {
                    b.x+=5;
                }
                if (b.y < (b.EnemyPosY - 1) * 50)
                {
                    b.y+=5;
                }
                if (b.x > (b.EnemyPosX - 1) * 50)
                {
                    b.x -=5;
                }
                if (b.y > (b.EnemyPosY - 1) * 50)
                {
                    b.y-=5;
                }
                //moves the player and enemy after the players turn
            }
            if (player.x < (player.PlayerX - 1) * 50)
            {
                player.x += 5;
            }
            if (player.y < (player.PlayerY - 1) * 50)
            {
                player.y += 5;
            }
            if (player.x > (player.PlayerX - 1) * 50)
            {
                player.x -= 5;
            }
            if (player.y > (player.PlayerY - 1) * 50)
            {
                player.y -= 5;
            }


        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShootOrMove == true)
            {
                reticle.x = e.X - 20;
                reticle.y = e.Y - 20;
                //have a reticle follow the mouse when the player wants to shoot
            }
            else
            {
                reticle.x = -40;
                reticle.y = -40;
            }
            foreach (Grid_Items f in floor)
            {
                if (f.FloorRec.Contains(e.Location))
                {
                    MousePosX = f.XPosition;
                    MousePosY = f.YPosition;
                }

                if (f.FloorRec.Contains(e.Location) && f.FloorRec.IntersectsWith(player.PlayerRec))
                {
                    f.Floor_Image = Properties.Resources.Base_Grid_Item2;
                    if (ShootOrMove == false)
                    { CanMove = false; }

                    if (ShootOrMove == true)
                    { CanShoot = false; }
                }//all this is for the different highlights the grid can have as you mouse over it
                else if (f.FloorRec.Contains(e.Location) && (MousePosX - player.PlayerX) <= 3 && (MousePosX - player.PlayerX) >= -3
                     && (MousePosY - player.PlayerY) <= 3 && (MousePosY - player.PlayerY) >= -3)
                {
                    f.Floor_Image = Properties.Resources.Grid_ItemH;
                    if (ShootOrMove == false)
                    { CanMove = true; }

                    if (ShootOrMove == true)
                    { CanShoot = true; }
                }
                else if (f.FloorRec.Contains(e.Location))
                {
                    f.Floor_Image = Properties.Resources.Grid_ItemN;
                    if (ShootOrMove == false)
                    { CanMove = false; }

                    if (ShootOrMove == true)
                    { CanShoot = false; }
                }
                else
                {
                    f.Floor_Image = Properties.Resources.Base_Grid_Item2;
                }


            }
        }
    }
}
