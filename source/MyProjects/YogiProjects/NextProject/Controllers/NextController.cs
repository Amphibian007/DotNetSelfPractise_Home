using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextProject.Models;

namespace NextProject.Controllers
{
    public class NextController : Controller
    {
        public string Index()
        {
            return "This is from next action method";
        }
        public IActionResult Show()
        {
            ViewBag.message = "This is from show method";
            return View();
        }
        public IActionResult Employee()
        {
            var e1 = new Employee()
            {
                Id = 1,
                Name = "Prakash",
                Area = "Dhaka",
                Post = "Manager"
            };
            return View(e1);
        }
    }
}
