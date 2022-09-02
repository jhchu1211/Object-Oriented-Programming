using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Q1
{
    class Student :Type
    {
        int grade;
        double gPA;
        string school;
        public Student() : base()
        {
            grade = 0;
            gPA = 0;
            school = "none";
        }
        public Student(string n, int g, double G, string S) : base(n)
        {
            grade = g;
            gPA = G;
            school = S;
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0) grade = value;
                else grade = 0;
            }
        }
        public double GPA
        {
            get { return gPA; }
            set
            {
                if (value >= 0) gPA = value;
                else gPA = 0;
            }
        }
        public string School
        {
            get { return school; }
            set { school = value; }
        }
        public override string ToString()
        {
            return name + " is in grade " + grade + " at " + school + " with a GPA of " + gPA;
        }
        ~Student() { }
    }
}
