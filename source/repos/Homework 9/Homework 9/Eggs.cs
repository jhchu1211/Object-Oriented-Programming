using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    class Eggs
    {
        private double unit_price;
        private int quantity;
        public Eggs()
        {
            unit_price = 4.00;
            quantity = 3;
        }
        public double total_price()
        {
            return (unit_price * quantity);
        }
        public override string ToString()
        {
            string n = String.Format("{0:0.00}", unit_price);
            string s = "Eggs\t$" + n + "\t\t" + quantity + "\n";
            return s;
        }
        ~Eggs() { }
    }
}
