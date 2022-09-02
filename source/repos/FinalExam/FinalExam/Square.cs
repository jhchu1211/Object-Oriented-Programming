using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class Square : GraphObject
    {
        private int seg;
        public Square()
        {
            seg = 0;
        }
        public Square(int S)
        {
            seg = S;
        }
        public int Seg
        {
            get { return seg; }
            set { seg = value; }
        }
        public override double cal_a()
        {
            area = seg * seg;
            return area;
        }
        public override double cal_p()
        {
            perimeter = seg * 4;
            return perimeter;
        }
        public override string ToString()
        {
            return "A square, segment = " + seg +  ",\t\t\tarea = " + cal_a() + ",\tperimeter = " + cal_p();
        }
        ~Square() { }
    }
}
