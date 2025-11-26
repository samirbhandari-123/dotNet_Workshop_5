using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal abstract class ElectronicDevice
    {
        public string Brand { get; set; }
        public double Price { get; set; }

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method to be implemented in derived classes
        public abstract void ShowInfo();
    }
}
