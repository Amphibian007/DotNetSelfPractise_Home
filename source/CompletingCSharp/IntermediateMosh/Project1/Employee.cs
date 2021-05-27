using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Employee
    {
        public Employee(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days/365;
                return years;
            }
        }
    }
}
