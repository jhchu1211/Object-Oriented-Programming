using System;

namespace Homework10Q02
{
    class Program
    {
        static void pause()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            double m = 2000;
            Checkings c = new Checkings(2000, m);
            Savings s = new Savings(3000, m);
            s.deposit(200);
            s.interest();
            s.Thresh();
            Console.WriteLine("$"+s.ToString());
            c.withdraw(1600);
            c.Thresh();
            Console.WriteLine(c.ToString());
            pause();
        }
    }
}
