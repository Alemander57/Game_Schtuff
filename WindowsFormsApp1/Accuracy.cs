using System;
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
    public partial class Accuracy : Form
    {
        Graphics g;
        int score,Time;
        public static int EndScore,DID;
        Random rnd = new Random();
        Reticle reticle = new Reticle();
        Enemy enemy = new Enemy(1,1);
        public Accuracy()
        {
            InitializeComponent();
            DID = 0;
            Time = 10;
            TimeBox.Text = Time.ToString();
           // Cursor.Position = (0);
        }
        //this is all just catch the alien, nothing too exciting...took me like 5 minutes to make
        private void Accuracy_Load(object sender, EventArgs e)
        {
            if(MainGmeFrm.Tutorial ==false)
            {
                MessageBox.Show("click on the aliens as they appear to up your score!", 
                    "Score above 8 to hit your enemy!");
                MainGmeFrm.Tutorial = true;
            }
        }

       public void Close_Tick(object sender, EventArgs e)
        {
            EndScore = score;
            this.Close();
            DID = 1;
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (reticle.RetRec.IntersectsWith(enemy.EnemyRec))
            {
                score++;
                enemy.x = rnd.Next(0, 350);
                enemy.y = rnd.Next(0, 350);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            reticle.DrawReticle(g);
            enemy.DrawEnemy(g);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Cursor.Hide();
            reticle.x = e.X-20;
            reticle.y = e.Y-20;


        }

        private void Time_Timer_Tick(object sender, EventArgs e)
        {
            Time--;
            TimeBox.Text = Time.ToString();


        }

        private void AlienTimer_Tick(object sender, EventArgs e)
        {
            enemy.x = rnd.Next(0,350);
            enemy.y = rnd.Next(0, 350);
        }

        private void Accuracy_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Show();
        }

        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            //VarSet = Form1.MousePosX;
            GlobalVarTest.Text = score.ToString();
            panel1.Invalidate();        
        }
    }
}
