using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation2.Models;

namespace Validation2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(Employee emp)

        {
            if (string.IsNullOrEmpty(emp.Name))
                ModelState.AddModelError(nameof(emp.Name), "Please enter your name");
            if (string.IsNullOrEmpty(emp.Designation))
                ModelState.AddModelError(nameof(emp.Designation), "Please enter your designation");

            if (ModelState.IsValid)
                return View("Details",emp);
            else
                return View("Index");
               
        }
    }
}
