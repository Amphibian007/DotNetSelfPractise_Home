using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TempData_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "My name is Dipto";
            ViewBag.var2 = "I am the best";
            TempData["var3"] = DateTime.Now.ToLongDateString();
            string[] myArr = { "Dipto", "Pias", "Prokas" };
            TempData["var4"] = myArr;

            return View();
        }

        public IActionResult AboutUs()
        {
            TempData.Keep("var3");
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
