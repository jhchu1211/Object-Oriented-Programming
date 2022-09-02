using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q02
{
    class Savings :BankAccount
    {
        double sMoney;
        public Savings() : base()
        {
            sMoney = 0;
        }
        public Savings(double s, double m) : base (m)
        {
            sMoney = s;
        }
        public void Thresh()
        {
            if (sMoney < 1000)
            {
                Console.WriteLine("Your balance in your savings account has fallen beneath $500");
                Console.WriteLine("Your checkings account will incur a monthly fee if a minimum threshhold of $1000 isn't met.");
                Console.WriteLine("Please have a total greater than $1000 within 30 days of receiving this message.");
            }
        }
        public void interest()
        {
            sMoney = sMoney * 1.029;
        }
        public void withdraw(double w)
        {
            sMoney = sMoney - w;
        }
        public void deposit(double d)
        {
            sMoney = sMoney + d;
        }
        public override string ToString()
        {
            return sMoney.ToString();
        }
        ~Savings() { }
    }
}
