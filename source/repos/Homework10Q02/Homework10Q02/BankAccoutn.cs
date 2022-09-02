using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q02
{
    abstract class BankAccount
    {
        protected double money;
        public BankAccount()
        {
            money = -1;
        }
        public BankAccount(double m)
        {
            money = m;
        }
        ~BankAccount() { }
    }
}
