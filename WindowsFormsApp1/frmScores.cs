﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmScores : Form
    {

        string binPath = Application.StartupPath + @"\Highscore.txt";
        List<HighScores> highScores = new List<HighScores>();
        public frmScores(string PlayerName,string PlayerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = PlayerName;
            lblPlayerScore.Text = PlayerScore;
            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));
            }
            reader.Close();



        }
        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }
        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }



        private void frmScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(lblPlayerScore.Text) > lowest_score)
            {
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text)));
            }
            else
            {
                lblMessage.Text = "Keep trying to make the top ten!";
            }
            SortHighScores();
            DisplayHighScores();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            SaveHighScores();
            Application.Restart();
        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                ListBoxName.Items.Add(s.Name);
                ListBoxScore.Items.Add(s.Score);

            }
        }

    }
}
