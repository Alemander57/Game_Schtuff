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
    public partial class Form1 : Form
    {
        Graphics g;

       List<Grid_Items> floor  = new List<Grid_Items>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < (this.Width / 50); i++)
            {
                int gridx = (i * 50);
                for (int l = 0; l < (this.Height / 50); l++)
                {
                    int gridy = (l * 50);
                    floor.Add(new Grid_Items((gridx), (gridy)));
                }
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            Cursor.Position.Y = Cursor.Position.Y+1;


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            floor.Clear();
            for (int i = 0; i < ((this.Width / 50)+1); i++)
            {
                int gridx = (i * 50);
                for (int l = 0; l < ((this.Height / 50)+1); l++)
                {
                    int gridy = (l * 50);
                    floor.Add(new Grid_Items((gridx), (gridy)));
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            foreach (Grid_Items f in floor)
            {

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            GridReset.Enabled = false;
            //gets rid of highlights and then disables until another square is highlighted
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Grid_Items f in floor)
            {

                if (f.FloorRec.Contains(e.Location))
                {
                    f.Floor_Image = Properties.Resources.Grid_ItemH;
                    
                }
             




            }
        }
    }
}
