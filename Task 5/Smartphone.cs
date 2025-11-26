using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: {Price}");
        }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }
    }
}
