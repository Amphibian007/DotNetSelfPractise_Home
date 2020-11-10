using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form2.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string Married { get; set; }

    }

    public enum Gender
    {
       male, female
    }
}
