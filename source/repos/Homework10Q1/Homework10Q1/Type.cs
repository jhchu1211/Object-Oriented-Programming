using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q1
{
    abstract class Type
    { 
        protected string name;
        public Type()
        {
            name = "none";
        }
        public Type(string n)
        {
            name = n;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        ~Type() { }
    }
}
