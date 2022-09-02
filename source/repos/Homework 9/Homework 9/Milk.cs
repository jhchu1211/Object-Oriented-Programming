using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    class Milk
    {
        private double unit_price;
        private int quantity;
        public Milk()
        {
            unit_price = 4.75;
            quantity = 1;
        }
        public double total_price()
        {
            return (unit_price * quantity);
        }
        public override string ToString()
        {
            string n = String.Format("{0:0.00}", unit_price);
            string s = "Milk\t$" + n + "\t\t" + quantity + "\n";
            return s;
        }
        ~Milk() { }
    }
}
