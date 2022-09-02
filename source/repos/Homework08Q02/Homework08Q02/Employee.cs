using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08Q02
{
    class Employee
    {
        //attributes
        //string fName;
        //string lName;
       // double totalSales;
        //int eNum;

        //getter and setter
        public string fName { get; set; }
        public string lName { get; set; }
        public double totalSales { get; set; }
        public int eNum { get; set; }
        //default constructor
        /*public Employee()
        {
            fName = "John";
            lName = "Dough";
            totalSales = 00;
            eNum = -1;
        }*/
        
        //mutator
        

        //behaviors
        public void money(double t)
        {
            double actual = t * 0.09;
            actual = actual - (actual * 0.18) - (actual * 0.10) - (actual * 0.06);
            Console.WriteLine($"Your total pay is ${actual}");
        }

        public void getInfo()
        {
            Console.Write("Please enter your first name: ");
            fName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lName = Console.ReadLine();
            Console.Write("Please enter your employee ID: ");
            eNum = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter your total sales: ");
            totalSales = Double.Parse(Console.ReadLine());
            Console.Write($"{fName} {lName}\nEmployee #{eNum}\nTotal Sales = ${totalSales}\n");
            money(totalSales);
            Console.ReadLine();
        }
    }
}
