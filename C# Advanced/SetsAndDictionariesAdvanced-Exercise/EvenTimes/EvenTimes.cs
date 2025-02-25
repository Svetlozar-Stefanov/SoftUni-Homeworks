﻿namespace EvenTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenTimes
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> counter = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!counter.ContainsKey(number))
                {
                    counter[number] = 0;
                }
                counter[number]++;
            }

            foreach (var item in counter)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
