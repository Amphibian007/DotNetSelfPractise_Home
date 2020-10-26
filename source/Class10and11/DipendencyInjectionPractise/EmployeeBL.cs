using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionPractise
{
    public class EmployeeBL
    {
        public EmployeeDAL employeeDal1;
        public List<Employee> GetEmployees()
        {
            employeeDal1 = new EmployeeDAL();
            return employeeDal1.ShowAllEmployees();
        }
    }
}
