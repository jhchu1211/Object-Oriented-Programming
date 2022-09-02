using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q02
{
    class Checkings : BankAccount
    {
        double cMoney;
        public Checkings() : base()
        {
            cMoney = 0;
        }
        public Checkings(double mm, double m) : base(m)
        {
            cMoney = mm;
        }
        public void Thresh()
        {
            if( cMoney < 500 )
            {
                Console.WriteLine("Your balance in your checkings account has fallen beneath $500");
                Console.WriteLine("Your checkings account will incur a monthly fee if a minimum threshhold of $500 isn't met.");
                Console.WriteLine("Please have a total greater than $500 within 30 days of receiving this message.");
            }
        }
        public void withdraw(double w)
        {
            cMoney = cMoney - w;
        }
        public void deposit(double d)
        {
            cMoney = cMoney + d;
        }
        public override string ToString()
        {
            return cMoney.ToString();
        }
        ~Checkings() { }
    }
}
