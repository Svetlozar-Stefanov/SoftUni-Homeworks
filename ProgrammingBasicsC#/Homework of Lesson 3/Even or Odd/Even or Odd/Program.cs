﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int LeftOff = number % 2;
            if (LeftOff == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
