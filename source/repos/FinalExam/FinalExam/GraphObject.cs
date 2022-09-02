using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    abstract class GraphObject : ICalculate
    {
        protected double area;
        protected double perimeter;
        public abstract double cal_p();
        public abstract double cal_a();
        public GraphObject()
        {
            area = 0;
            perimeter = 0;
        }
        /*protected double Area()
        {
            return area;
        }
        protected double Perimeter()
        {
            return perimeter;
        }
        public GraphObject(double P, double A)
        {
            area = A;
            perimeter = P;
        }*/
        ~GraphObject() { }
    }
}
