using FirstCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCRUD.Repositories
{
    public static class EmployeeRepository
    {
        public static List<Employee> allEmployees = new List<Employee>();
        public static IEnumerable<Employee> showAllEmployees
        {
            get { return allEmployees; }
        }

        public static void Create(Employee employee)
        {
            allEmployees.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            allEmployees.Remove(employee);
        }
    }
}
