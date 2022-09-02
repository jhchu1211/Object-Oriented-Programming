using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class RightTriangle : GraphObject
    {
        private int height;
        private int b;
        public RightTriangle()
        {
            height = 0;
            b = 0;
        }
        public RightTriangle(int H, int B)
        {
            height = H;
            b = B;
        }
        public override double cal_a()
        {
            area = b * height * 0.5;
            return area;
        }
        public override double cal_p()
        {
            double c2 = height * height + b * b;
            double c = Math.Sqrt(c2);
            perimeter = c + b + height;
            return perimeter;
        }
        public override string ToString()
        {
            return "A triangle, height = " + height + ",\tbase = " + b + ",\tarea = " + cal_a() + ",\tperimeter = " + cal_p();
        }
        ~RightTriangle() { }
    }
}
