using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of derived classes
            Car myCar = new Car();
            Bike myBike = new Bike();

            // Call Display() method (concrete) from base class
            myCar.Display();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine(); // Blank line

            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}
