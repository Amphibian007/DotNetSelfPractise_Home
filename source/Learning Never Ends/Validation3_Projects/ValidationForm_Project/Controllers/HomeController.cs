using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationForm_Project.Models;

namespace ValidationForm_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(Employee emp)
        {
            var model = new Employee()
            {
                Name = "Dipto",
                Gender = "Male"
            };
            if (ModelState.IsValid)
            {
                return View("Details", emp);
            }
            else
                return View("Index");
        }
    }
}
