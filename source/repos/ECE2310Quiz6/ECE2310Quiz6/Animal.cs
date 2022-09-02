using System;
using System.Collections.Generic;
using System.Text;

namespace ECE2310Quiz6
{
    abstract class Animal
    {
        public int age;
        
        public Animal()
        {
            age = -1;
        }

        public Animal(int a)
        {
            age = a;
        }

        public abstract void Move();
        
        public override string ToString()
        {
            return "Animal age is " + age;
        }
        ~Animal() { }
    }
}
