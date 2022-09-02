using System;

namespace FinalExam
{
    class Program
    {
        public static object NUtilites { get; private set; }

        public static void pause()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            RightTriangle one = new RightTriangle(6, 8);
            RightTriangle three = new RightTriangle(5, 15);
            Square two = new Square(8);
            Square four = new Square(7);
            Console.WriteLine("#1 obejct: " + one.ToString());
            Console.WriteLine("#2 obejct: " + two.ToString());
            Console.WriteLine("#3 obejct: " + three.ToString());
            Console.WriteLine("#4 obejct: " + four.ToString());
            double[] perimeter = new double[4] { one.cal_p(), two.cal_p(), three.cal_p(), four.cal_p() };
            double[] area = new double[4] { one.cal_a(), two.cal_a(), three.cal_a(), four.cal_a() };
            NUtilities find = new NUtilities();
            Console.WriteLine();
            find.FindLargest(ref perimeter, "perimeter");
            find.FindLargest(ref area, "area");
            pause();
        }
    }
}
