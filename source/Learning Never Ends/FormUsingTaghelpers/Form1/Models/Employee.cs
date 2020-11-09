using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }

        public string Married { get; set; }
    }

    public enum Gender
    {
        Male,
        Felmale
    }
}
