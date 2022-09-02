using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    abstract class ReadingMaterial : IPrintable
    {
        protected string date; protected string author;
        protected string genre; protected string title;
        public ReadingMaterial()
        {
            date = "00/00/0000"; author = "Last, First";
            genre = "Generic"; title = "Title";
        }
        public ReadingMaterial(string d, string a, string g, string t)
        {
            date = d; author = a; genre = g; title = t;
        }
        public string Date
        {
            get { return date; } set { date = value; }
        }
        public string Author
        {
            get { return author; } set { author = value; }
        }
        public string Genre
        {
            get { return genre; } set { genre = value; }
        }
        public string Title
        {
            get { return title; } set { title = value; }
        }
        public abstract void Print(string d);
        ~ReadingMaterial() { }
    }
}
