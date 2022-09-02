using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07Q02
{
    class Program
    {
        static int Power(int Base, int exponent)
        {
            int answer = Base;
            int og = Base;
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= exponent; i++)
                {
                    answer = answer * og;
                }
                return answer;
            }
        }
        static void Pause()
        {
            Console.WriteLine("Please press enter to continue");
            Console.ReadKey(true);
        }
        static int checker()
        {
            bool check = Int32.TryParse(Console.ReadLine(), out int n) && n > 0;
            if (!check)
            {
                do
                {
                    Console.WriteLine("Please enter a positive integer");
                    check = Int32.TryParse(Console.ReadLine(), out n) && n > 0;
                } while (!check);
            }
            return n;
        }
        static void Main(string[] args)
        {
            int Start = 0;
            for (int i = 0; i <= 10; i++)
            {
                Start = Start + Power(2, i);
            }
            Console.WriteLine(Start);
            Pause();
        }
    }
}
