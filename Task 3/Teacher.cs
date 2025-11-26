using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Teacher
    {
        public string Name { get; set; }

        // Virtual method to allow overriding
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Non-overridable method
        //public sealed void SalaryInfo()
        //{
        //    Console.WriteLine("Salary Info cannot be overridden.");
        //}
    }
}
