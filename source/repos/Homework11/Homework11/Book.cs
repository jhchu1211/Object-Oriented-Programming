﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    class Book : ReadingMaterial
    {
        double price;
        public Book() : base()
        {
            price = 0.00;
        }
        public Book(string d, string a, string g, string t, double p) : base(d,a,g,t)
        {
            price = p;
        }
        public override void Print(string d)
        {
            Console.WriteLine(title + " was published in " + d);
        }
        public override string ToString()
        {
            string p = String.Format("{0:0.00}", price);
            return title + " by " + author + "was published in " + date + " and is located in the " + genre + " aisle and costs $" + p;
        }
        ~Book() { }
    }
}
