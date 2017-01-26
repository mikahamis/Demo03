using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from Car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Colour = "Yellow";
            car.Engine = 0.5;
            car.Speed = 10;
            car.FuzzyDice = true;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperty = 42;
            car.PrintData();

            // create another car object
            string model = "Speedster";
            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Colour = "Black";
            Console.WriteLine("Colour is " + nascar.Colour);
        }
    }
}
