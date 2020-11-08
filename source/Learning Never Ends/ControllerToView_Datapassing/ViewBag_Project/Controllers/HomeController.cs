using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewBag_Project.Models;

namespace ViewBag_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.var1 = "Data from dipto view";
            ViewBag.var2 = 20;
            List<string> myList = new List<string>();
            myList.Add("Dipto");
            myList.Add("I am the best");
            myList.Add("Pias");

            ViewBag.var3 = myList;

            var employee1 = new Employee() {
                Id = 1,
                Name="Dipto",
                City="Gazipur"
            };

            ViewBag.var4 = employee1;
            return View();         
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
