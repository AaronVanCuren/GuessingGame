﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGameUI UI = new GuessingGameUI();
            GuessingGameUI.Run();
        }
    }
}