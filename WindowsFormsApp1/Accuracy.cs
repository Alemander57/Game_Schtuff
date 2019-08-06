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
        public Accuracy()
        {
            InitializeComponent();
        }

        private void Accuracy_Load(object sender, EventArgs e)
        {

        }

       public void Close_Tick(object sender, EventArgs e)
        {
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

        }
    }
}
