﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors )
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public int CompareTo(Book other)
        {
            if (Year - other.Year != 0)
            {
                return Year.CompareTo(other.Year);
            }
            if (Title != other.Title)
            {
                return Title.CompareTo(other.Title);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
