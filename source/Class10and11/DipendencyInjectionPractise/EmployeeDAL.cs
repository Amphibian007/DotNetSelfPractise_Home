using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionPractise
{
    public class EmployeeDAL
    {
        public List<Employee> ShowAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Dipto" });
            employees.Add(new Employee { Id = 2, Name = "Pias" });
            employees.Add(new Employee { Id = 3 ,Name = "Sujan" });
            employees.Add(new Employee { Id = 4, Name = "Prokash" });

            return employees;
        }
    }
}
