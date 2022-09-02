using System;

namespace Homework_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk m = new Milk();
            Eggs e = new Eggs();
            Bread b = new Bread();
            Grocery my_grocery = new Grocery(m, e ,b);
            string s = my_grocery.ToString();
            Console.WriteLine(s);
            my_grocery.expense();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

        }
    }
}
