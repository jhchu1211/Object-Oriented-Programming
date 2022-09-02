
using System;

namespace ECE2310Quiz6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter age and color of bird");
            int age = Convert.ToInt32(Console.ReadLine());
            string color = Console.ReadLine();
            Bird dove = new Bird(color, age);
            dove.Sing();
            dove.Move();
            dove.ToString();

        }
    }
}
