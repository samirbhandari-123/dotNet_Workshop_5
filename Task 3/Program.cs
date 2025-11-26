using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading demonstration
            Printer printer = new Printer();
            printer.Print("Hello, i am basically from Dulari");
            printer.Print(123);
            printer.Print("Repeat this message", 3);

            Console.WriteLine(); // blank line

            // Inheritance + Polymorphism demonstration
            NepaliTeacher nepaliTeacher = new NepaliTeacher { Name = "Shyam" };
            EnglishTeacher englishTeacher = new EnglishTeacher { Name = "Basudev" };

            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();
        }
    }
}
