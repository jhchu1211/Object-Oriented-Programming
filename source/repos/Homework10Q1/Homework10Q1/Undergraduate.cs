using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q1
{
    class Undergraduate :Student
    {
        string institution;
        string major;
        double nGPA;
        int year;
        public Undergraduate() : base()
        {
            institution = "none";
            major = "none";
            nGPA = 0;
            year = 0;
        }
        public Undergraduate(string n, int g, double G, string S, string i, string m, double nG, int y) : base(n,g,G,S)
        {
            institution = i;
            major = m;
            nGPA = nG;
            year = y;
        }
        public string Institution
        {
            get { return institution; }
            set { institution = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public double NGPA
        {
            get { return nGPA; }
            set
            {
                if (value >= 0) nGPA = value;
                else nGPA = 0;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 0) year = value;
                else year = 0;
            }
        }
        public override string ToString()
        {
            string n = name + " is a year " + year + " at " + institution + " with a GPA of " + nGPA + " studying " + major + "\n";
            string u = name + " graduated from " + School + " with a GPA of " + GPA + "\n";
            return n + u;
        }
    }
}
