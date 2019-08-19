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
    public partial class frmScores : Form
    {
        public frmScores(string PlayerName,string PlayerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = PlayerName;
            lblPlayerScore.Text = PlayerScore;

        }

        private void frmScores_Load(object sender, EventArgs e)
        {

        }
    }
}
