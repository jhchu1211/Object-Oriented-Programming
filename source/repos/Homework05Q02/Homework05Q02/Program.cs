using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05Q02
{
    class Program
    {
        static double checker()
        {
            Console.WriteLine("Please enter a grade");
            bool valid1 = double.TryParse(Console.ReadLine(), out double a) && a >= 0 && a <= 100;
            if (!valid1)
            { 
                do
                {
                    Console.WriteLine("The following was an incorrect input. Please enter a number from 0 to 100:");
                    valid1 = double.TryParse(Console.ReadLine(), out a) && a >= 0 && a <= 100;
                } while (!valid1);
            }
            return a;
        }
        static void pause()
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string s;
            double n;
            int counter = 0;
            int acounter = 0;
            double maximum = 0;
            string[] a = new string[1000000];
            double[] g = new double[1000000];
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Please enter a name or type done when you are finished");
                s = Console.ReadLine();
                if (s == "done")
                {
                    break;
                }
                a[i] = s;
                n = checker();
                g[i] = n;
                counter++;
            }
            maximum = g.Max();
            int index = Array.IndexOf(g, maximum);
            int c = 0;
            double total = 0;
            int max = counter;
            while (c != max)
            {
                Console.WriteLine(a[c] + "\t\t" + g[c]);
                total = total + g[c];
                c++;
            }
            double average = total / (max);
            for (int i = 0; i < counter; i++)
            {
                if (g[i] > average)
                {
                    acounter++;
                }
            }
            Console.WriteLine(a[index] + " has the highest score of " + g[index]);
            Console.WriteLine("The average score of the class is " + average);
            Console.WriteLine(acounter + " students are above average");
            pause();
        }
    }
}
