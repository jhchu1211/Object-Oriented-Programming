using System;

namespace Homework11
{
    class Program
    {
        static void pause()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Book TLT = new Book("October 16th", "Rick Riordan", "Adventure", "Percy Jackson: The Lightning Thief", 11);
            Magazine idk = new Magazine();
            Magazine test = new Magazine("May 11th", "Johnny Chu", "Thriller", "The Boy who was Scared", 1.00);
            Console.WriteLine(TLT.ToString());
            TLT.Print("October 15th");
            Console.WriteLine(TLT.ToString());
            Console.WriteLine(idk.ToString());
            Console.WriteLine(test.ToString());
            test.Print("June 10");
            Console.WriteLine(test.ToString());
            pause();
        }
    }
}
