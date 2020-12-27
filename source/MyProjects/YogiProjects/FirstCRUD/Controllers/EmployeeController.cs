using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCRUD.Models;
using FirstCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(EmployeeRepository.showAllEmployees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeRepository.Create(employee);
            return View("Thanks",employee);
        }

        public IActionResult Update(string empname)
        {
            var employee = EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault().Id = employee.Id;
            EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;
            EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            var employee = EmployeeRepository.allEmployees.Where(e => e.Name == empname).FirstOrDefault();
            EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
