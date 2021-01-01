using CRUD1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Repositories
{
    public static class EmployeeRepository
    {
        public static List<Employee> allEmployees = new List<Employee>();
        public static IEnumerable<Employee> iterateEmployees
        {
            get { return allEmployees; }
        }
        public static void Create(Employee em1)
        {
            allEmployees.Add(em1);
        }
        public static void Delete(Employee em1)
        {
            allEmployees.Remove(em1);
        }
    }
}
