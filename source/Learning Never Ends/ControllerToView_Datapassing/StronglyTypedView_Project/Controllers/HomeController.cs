using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedView_Project.Models;

namespace StronglyTypedView_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employee1 = new Employee()
            {
                id = 1,
                name = "Dipto",
                city = "Gazipur"
            };

            var employee2 = new Employee()
            {
                id = 2,
                name = "Pias",
                city = "Gazipur"
            };

            var employee3 = new Employee()
            {
                id = 3,
                name = "Prokash",
                city = "Narsingdi"
            };

            List<Employee> myList = new List<Employee>();
            myList.Add(employee1);
            myList.Add(employee2);
            myList.Add(employee3);
            return View(myList);
        }
    }
}
