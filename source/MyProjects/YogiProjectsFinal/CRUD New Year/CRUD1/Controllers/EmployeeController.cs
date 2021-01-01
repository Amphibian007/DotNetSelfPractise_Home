using CRUD1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositories.EmployeeRepository.iterateEmployees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repositories.EmployeeRepository.Create(employee);
            return View("Thanks", employee);
        }
        public IActionResult Update(string employeeName)
        {
            var employee = Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee,string employeeName)
        {
            Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault().Age=employee.Age;
            Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault().Name=employee.Name;
            Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault().Salary = employee.Salary ;
            Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault().Department=employee.Department;
            Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == employeeName).FirstOrDefault().Gender=employee.Gender;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(string empName)
        {
            var employee = Repositories.EmployeeRepository.allEmployees.Where(e => e.Name == empName).FirstOrDefault();
            Repositories.EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
