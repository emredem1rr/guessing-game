﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Player
    {
        //deneme
        public string Name { get; set; }

        public int Score { get; set; }

        public void AlterScore(int amount) => this.Score += amount;
    }
}
