﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5logicalprograms
{
    internal class Day5problems
    {
        public void Leap_Year()
        {
            int year = 2022;
            if (year > 1000 && year < 9999)
            {
                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine("Leay year.");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input .");
            }
        }


    }
}
