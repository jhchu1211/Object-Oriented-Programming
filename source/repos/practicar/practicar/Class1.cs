
using System;
using System.Collections.Generic;
using System.Text;

namespace practicar
{
    class Car
    {
        //attributes /data members
        double price;
        String color;
        int numOfSeats;
        String make;


        //behaviors / member methods
        //default constructor
        public Car()
        {
            price = 20000;
            color = "unknown";
            numOfSeats = 5;
            make = "Ford";
        }
        //overloading constructors
        public Car(double p, string c)
        {
            price = p;
            color = c;
            numOfSeats = 5;
            make = "Ford";
        }
        public Car(double p, string c, int n, string m)
        {
            price = p;
            color = c;
            numOfSeats = n;
            make = m;
        }
        public void Drive()
        {
            Console.WriteLine("Someone is driving the car");
        }

        public double PriceDepreciate(double rate)
        {
            price = price * (1 - rate);
            return price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"A {color} {make} with {numOfSeats} seats priced at ${price}");
        }
        //destructor
        ~Car() { }


    }
}
