﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name,int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
            {
                return Name.CompareTo(other.Name);
            }
            if (Age != other.Age)
            {
                return Age.CompareTo(other.Age);
            }
            if (Town != other.Town)
            {
                return Town.CompareTo(other.Town);
            }
            return 0;
        }
    }
}
