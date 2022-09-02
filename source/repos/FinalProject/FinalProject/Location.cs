using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Location
    {
        public int x;
        public int y;
        public Location()
        {
            x = 0;
            y = 0;
        }
        public Location(int a, int b)
        {
            x = a;
            y = b;
        }
        public double FindDistance(int aa, int bb)
        {
            double a;
            double b;
            double x; double y;
            a = Convert.ToDouble(aa);
            b = Convert.ToDouble(bb); 
            x = a; y = b;
            double h = x * x + y * y;
            h = Math.Sqrt(h);
            return h;
        }
        public override string ToString()
        {
            return " at location (" + x + ","+y +") ";
        }
        ~Location() { }
    }
}
