using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Q01
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
            Console.WriteLine("Please enter the amount of Fibonacci numbers you would like to see: ");
            Console.WriteLine("");
            bool fbn = Int32.TryParse(Console.ReadLine(), out int lmt) && lmt >= 1;
            if (!fbn)
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("INVALID RESPONSE");
                    if (lmt < 1)
                    {
                        Console.WriteLine("Please input a positive number");
                    }
                    Console.WriteLine("Please enter an integer greater than 1: ");
                    fbn = Int32.TryParse(Console.ReadLine(), out lmt) && lmt >= 1;
                } while (!fbn);
            }
            int f = 1;
            int l = 0;
            int u = 1;
            for(int i = 1; i <= lmt; i++)
            {
                Console.Write(f + "\t");
                f = u + l;
                l = u;
                u = f;
                
                if ((i) % 5 == 0)
                {
                    Console.WriteLine("");
                }

            }
            Pause();
        }
    }
}
