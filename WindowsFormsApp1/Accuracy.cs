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
        int VarSet,score;
        public static int EndScore;
        Random rnd = new Random();
        Reticle reticle = new Reticle();
        Enemy enemy = new Enemy(1,1);
        public Accuracy()
        {
            InitializeComponent();
        }

        private void Accuracy_Load(object sender, EventArgs e)
        {

        }

       public void Close_Tick(object sender, EventArgs e)
        {
            EndScore = score;
            this.Close();

        }

        private void Accuracy_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Accuracy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                this.Close();


            }
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
            Cursor.Hide();
            reticle.x = e.X-20;
            reticle.y = e.Y-20;


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
