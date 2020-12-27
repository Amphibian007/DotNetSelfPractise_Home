using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "This is Dipto";
        }
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult PersonInfo()
        {
            var person1 = new Person
            {
                Id = 1,
                Name = "Pias",
                Area = "Gazipur",
                Occupation = "Student"
            };
            return View(person1);
        }
    }
}
