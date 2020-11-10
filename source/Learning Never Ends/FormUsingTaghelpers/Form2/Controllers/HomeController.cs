using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Details(Employee emp)
        {
            return ($"{emp.Name}, {emp.Age}, {emp.Salary}, {emp.Gender},{emp.Married}");
        }
    }
}
