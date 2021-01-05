using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YogiCRUD1.Data_Access_Layer;
using YogiCRUD1.Models;

namespace YogiCRUD1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyContext _companyContext;
        public HomeController(ILogger<HomeController> logger,CompanyContext companyContext)
        {
            _companyContext = companyContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee employee)
        {
           
            _companyContext.Entry(employee).State = EntityState.Added;
            _companyContext.SaveChanges();
            return View("Success");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Display()
        {
            IEnumerable<Employee> employeeList = _companyContext.Employee.Include(e=>e.Department);
            //var emp =  _companyContext.Employee.Where(e => e.Name == "Dipto")
            //                       .FirstOrDefault();
            //string deptName = emp.Department.Name;
            return View(employeeList);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
