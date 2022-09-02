using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q1
{
    class Graduate :Undergraduate
    {
        string degree;
        string nI;
        public Graduate() : base()
        {
            degree = "none";
            nI = "none";
        }
        public Graduate(string n, int g, double G, string S, string i, string m, double nG, int y, string d, string nI) : base(n,g,G,S,i,m,nG,y)
        {
            degree = d;
        }
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string NI
        {
            get { return nI; }
            set { nI = value; }
        }
        public override string ToString()
        {
            string b = name + " was awarded the " + degree + " and is now studying as a graduate student at " + nI + "\n";
            string m = name + " graduated from " + Institution + " with a GPA of " + NGPA + " studying " + Major + "\n";
            string e = name + " graduated from " + School + " with a GPA of " + GPA + "\n";
            return b + m + e;
        }

    }
}
