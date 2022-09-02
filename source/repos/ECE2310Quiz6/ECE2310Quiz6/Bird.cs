using System;
using System.Collections.Generic;
using System.Text;

namespace ECE2310Quiz6
{
    class Bird :Animal
    {
        private string color;

        public Bird()
        {
            color = "invalid";
        }

        public Bird(string c, int a)
        {
            color = c;
            age = a;
        }
        public void Sing()
        {
            Console.WriteLine("tweet");
        }
        public override void Move()
        {
            Console.WriteLine("The {0} bird is flying high", color);
        }

        public override string ToString()
        {
            return color + " bird is " + age + " years old.";
        }
        ~Bird() { }
    }
}
