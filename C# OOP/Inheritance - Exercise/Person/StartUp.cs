﻿using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person child = new Person(name, age);
            Console.WriteLine(child);
        }
    }
}