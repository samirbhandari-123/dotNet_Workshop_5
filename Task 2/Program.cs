using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of derived classes
            Car myCar = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle myMotorcycle = new Motorcycle { Brand = "Honda", Speed = 80, HasCarrier = true };

            // Call base class methods
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine(); // blank line

            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();
        }
    }
}
