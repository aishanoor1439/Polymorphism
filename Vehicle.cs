using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Vehicle
    {
        public virtual void startEngine()
        {
            Console.WriteLine("Engine has been started.");
        }

    }
    class Truck : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Truck engine has been started.");
        }
    }
    class Car : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Car engine has been started.");
        }
    }
    class MotorBike : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Motor bike engine has been started.");
        }
        public new void display()
        {
            Console.WriteLine("I am a child class.");
        }
    }
}
