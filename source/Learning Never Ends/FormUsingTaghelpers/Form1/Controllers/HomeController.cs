using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(Employee emp)
        {
            return ($"Name is {emp.Name} , age is {emp.Age} ,gender is{emp.Gender}" +
                  $"designation is {emp.Designation} and marital status is {emp.Married}");
        }
    }
}
