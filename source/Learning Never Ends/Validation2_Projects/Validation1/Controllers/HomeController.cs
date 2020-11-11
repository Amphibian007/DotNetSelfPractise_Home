using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation1.Models;

namespace Validation1.Controllers
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
            return ($"{emp.Name} and{emp.age}");
        }
    }
}
