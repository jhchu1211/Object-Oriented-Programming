using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Employee
    {
        //attributes
        string fName;
        string lName;
        int empNum;
        double salary;

        //methods aka behaviors
        public void annualPay(int hour)
        {
            Console.WriteLine($"{fName} {lName} receieves an annual pay of ${salary * hour * 52}");
        }

        public void showAll()
        {
            Console.WriteLine($"Employee #{empNum}: {fName} {lName}\t${salary} per hour");
        }

        //default constructor
        public Employee()
        {
            fName = "John";
            lName = "Dough";
            empNum = -1;
            salary = 0;
        }

        //overload constructor
        public Employee(string f, string l, int e, double s)
        {
            fName = f;
            lName = l;
            empNum = e;
            salary = s;
        }
    }
}
