using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    class Bread
    {
        private double unit_price;
        private int quantity;
        public Bread()
        {
            unit_price = 2.50;
            quantity = 2;
        }
        public double total_price()
        {
            return (unit_price * quantity);
        }
        public override string ToString()
        {
            string n = String.Format("{0:0.00}", unit_price);
            string s = "Bread\t$" + n + "\t\t" + quantity + "\n";
            return s;
        }
        ~Bread() { }
    }
}
