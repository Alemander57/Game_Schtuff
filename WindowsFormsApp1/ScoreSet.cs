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
    public partial class ScoreSet : Form
    {
        public ScoreSet()
        {
            InitializeComponent();
            TBScore.Text = MainGmeFrm.Score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmScores frmScores2 = new frmScores(TBName.Text, TBScore.Text);
            Hide();
            frmScores2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBName.Enabled = false;
        }
    }
}
