using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07Q01
{
    class Program
    {
        static int Ssearch(int n, int[] a)
        {
            int total = a.GetLength(0);
            int i;
            for (i = 0; i < total; i++)
            {
                if(a[i] == n)
                {
                    return i;
                }
            }
            return 0;
        }
        static void Search(int n, int[] a)
        {
            int count = 0; int total; int i;
            total = a.GetLength(0);
            for (i = 0; i < total; i++)
            {
                if (a[i] == n)
                {
                    Console.WriteLine($"Student #{i + 1} earned {n}%");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"None of the students earned {n}%");
            }
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
        static void Pause()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey(true);
        }
        static int checker1()
        {
            bool check = Int32.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 100;
            if (!check)
            {
                do
                {
                    Console.WriteLine("Please enter a score form 0 - 100: ");
                    check = Int32.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 100;
                } while (!check);
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of students = ");
            int n = checker();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please enter the score of Student #{i + 1}");
                a[i] = checker1();
            }
            Search(100, a);
            Pause();
        }
    }
}
