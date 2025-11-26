using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create store
            ElectronicsStore store = new ElectronicsStore();

            // Create devices
            Laptop laptop1 = new Laptop("Dell", 60000);
            Smartphone phone1 = new Smartphone("Samsung", 80000);

            // Add devices to store
            store.AddDevice(laptop1);
            store.AddDevice(phone1);

            // Display all device details
            store.ShowAllDeviceDetails();
        }
    }
}
