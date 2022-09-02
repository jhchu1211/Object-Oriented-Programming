using System;

namespace practicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(40000, "red");
            Car yourCar = new Car(30000, "blue", 7, "Toyota");
            myCar.DisplayInfo();
            Console.WriteLine("After a year my car is now worth ${0}", myCar.PriceDepreciate(0.2));

            yourCar.DisplayInfo();
            Console.WriteLine("After a year your car is now worth ${0}", yourCar.PriceDepreciate(0.1));

            myCar.Drive();


        }
    }
}
