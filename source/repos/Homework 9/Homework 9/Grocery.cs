using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    class Grocery
    {
        
        private Milk my_milk = new Milk();
        private Eggs my_eggs = new Eggs();
        private Bread my_bread = new Bread();
        public Grocery(Milk my_milk, Eggs my_eggs, Bread my_bread)
        {
            this.my_bread = my_bread;
            this.my_milk = my_milk;
            this.my_eggs = my_eggs;
        }
        public void expense()
        {
            double total = my_milk.total_price() + my_eggs.total_price() + my_bread.total_price();
            Console.WriteLine("The total cost for this grocery list is $" + total);
        }
        public override string ToString()
        {
            string top = "Item\tUnit Price\tQuantity\n";
            return top + my_milk.ToString() + my_bread.ToString() + my_eggs.ToString();
        }
        ~Grocery() { }
    }
}
