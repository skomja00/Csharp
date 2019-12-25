using System;
using static System.Console;

namespace Packt.Shared{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }
        
         public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
        public new void WriteToConsole()
        {
            WriteLine(
                format: "{0} was born on {1:dd/MM/yyyy} and hired on {2:dd/MM/yyyy}.",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HireDate
            );
        }
    }
}