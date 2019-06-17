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

            for (int i = 0; i < (); i++)
            {
                int gridx = (i*50);
                for (int l = 0; l < 10; l++)
                {
                    int gridy = (l * 50);
                    floor.Add(new Grid_Items((gridx),(gridy)));
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
    }
}
