using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // Sealed class cannot be inherited
    internal sealed class EnglishTeacher : Teacher
    {
        // Uses base class Teaching() method
        // SalaryInfo() cannot be overridden
    }
}
