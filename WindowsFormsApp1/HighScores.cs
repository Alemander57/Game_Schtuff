﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HighScores
    {
        public HighScores(string name, int score)
        {
            Name = name;
            Score = score;
        }
        //set properties so we can access the name and score
        public string Name { get; set; }

        public int Score { get; set; }


    }
}
