using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Q02
{
    class Program
    {
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Age" + "\t\t" + "Linda's Account" + "\t\t" + "John's Account");
            Console.WriteLine("-----------------------------------------------------------------");
            double L = 1000.001;
            double J = 1000.001;
            for (int age = 20; age <= 60; age = age + 10)
            {
                Console.Write(age + "\t\t");
                decimal ld, jd;
                ld = decimal.Round(Convert.ToDecimal(L), 2, MidpointRounding.AwayFromZero);
                jd = decimal.Round(Convert.ToDecimal(J), 2, MidpointRounding.AwayFromZero);
                Console.Write("$" + ld + "\t\t");
                Console.Write("$" + jd + "\t\t"); Console.WriteLine("");
                L = L * Math.Pow(1.06, 10);
                J = J * Math.Pow(1.015, 10);
            }
            Pause();
        }
    }
}
