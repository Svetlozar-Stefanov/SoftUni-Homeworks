﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_N_to_Smth
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(current);
                current *= 4;
            }
        }
    }
}
