using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Car();
            //v.startEngine();
            //Vehicle v1 = new MotorBike();
            //v1.startEngine();
            //Vehicle v2 = new Truck();
            //v2.startEngine();
            List <Vehicle> vehicles = new List<Vehicle>
            {
                new MotorBike(),
                new Car(),
                new Truck()

            };
            foreach(Vehicle v in vehicles)
            {
                v.startEngine();
            }

        }
    }
}
