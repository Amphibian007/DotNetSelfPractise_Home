using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Form2.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string Married { get; set; }

    }

    public enum Gender
    {
       male, female
    }
}
