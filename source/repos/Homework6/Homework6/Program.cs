using System;

namespace Homework6
{
    class Program
    {
        static bool isPerfect(int n)
        {
            int dSum = 0;
            double dN = Convert.ToDouble(n);
            for(int i = 1; i<n; i++)
            {
                if (n / i == dN / i)
                {
                    dSum = dSum + i;
                }
            }
            if (dSum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void print(int n)
        {
            int dSum = 0;
            double dN = Convert.ToDouble(n);
            for (int i = 1; i < n; i++)
            {
                if (n / i == dN / i)
                {
                    dSum = dSum + i;
                    Console.Write(i);
                    if (i < n / 2)
                    {
                        Console.Write(" + ");
                    }
                    else if (i == n / 2)
                    {
                        Console.Write(" = ");
                    }
                }
            }
            Console.Write(dSum + "\n");
            Console.WriteLine(n + " = " + dSum);
        }
        static void pause()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2000; i++)
            {
                if (isPerfect(i))
                {
                    print(i);
                }
            }
            int c = 0;
            for (int i = 5; i <= 5000; i++)
            {
                if (isPerfect(i))
                {
                    c++;
                }
            }
            Console.WriteLine("There are " + c + " perfect numbers between 5 and 5000");
            pause();
        }
    }
}
