using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractise
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        private void ShowEmployeeName()
        {
            Console.WriteLine("This is the new employee name");
        }
    }
}
