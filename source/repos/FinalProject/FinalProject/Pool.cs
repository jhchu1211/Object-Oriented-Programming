using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Pool
    {
        string name;
        Location l = new Location();
        Temperature t = new Temperature();
        public Pool()
        {
            name = " ";
        }
        public Pool(string n, int x, int y)
        {
            name = n;
            l = new Location(x, y);
        }
        public void Sett(double d, string s)
        {
            t = new Temperature(d, s);
        }
        public void SettL(int x, int y)
        {
            l = new Location(x, y);
        }
        public double Gett()
        {
            return l.FindDistance(l.x, l.y);
        }
        public int x()
        {
            return l.x;
        }
        public int y()
        {
            return l.y;
        }
        public override string ToString()
        {
            return "Pool " + name + l.ToString() + t.ToString();
        }
        ~Pool() { }
    }
}
