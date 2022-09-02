using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fake = new Employee();
            Employee me = new Employee("Jobbi", "Churro", 0, 12.00);

            fake.showAll();
            fake.annualPay(20);
            me.showAll();
            me.annualPay(20);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
