using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Temperature
    {
        double degree;
        string scale;
        public Temperature()
        { degree = 0; scale = " "; }
        public Temperature(double d, string s)
        {
            degree = d; scale = s;
        }
        public double Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string Scale
        {
            get { return scale; }
            set { scale = value; }

        }
        public override string ToString()
        {
            Convert.ToString(degree);
            return " is set to " +degree + " * " + scale;
        }
        ~Temperature() { }
    }
}
