using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewData_Project.Models;

namespace ViewData_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["myVar"] = "My name is Dipto";
            ViewData["myVar2"] = DateTime.Now;
            string[] myArr = { "Dipto", "Pias", "Sujan" };

            ViewData["myVar3"] = myArr;

            List<double> myDoubleList = new List<double>();
            myDoubleList.Add(10);
            myDoubleList.Add(20);
            myDoubleList.Add(30);
            myDoubleList.Add(40);
            myDoubleList.Add(50);

            ViewData["myVar4"] = myDoubleList;

            var dipto = new Student();
            dipto.id = 1;
            dipto.name = "Dipto Das";
            dipto.gender = "Male";

            var pias = new Student()
            {
                id = 2,
                name = "Hridik Das",
                gender = "Male"
            };
            ViewData["myVarDipto"] = dipto;
            ViewData["myVarPias"] = pias;

            return View();

        }
    }
}
