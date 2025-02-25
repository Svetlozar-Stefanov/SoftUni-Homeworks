﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Vegetable
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public Vegetable(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public override string ToString()
        {
            return $" - {Name} have {Calories} calories";
        }
    }
}
