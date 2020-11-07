using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLayout1.Models;

namespace MyLayout1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var food1 = new Food()
            {
                id = 1,
                name = "Jackfruit",
                age = 15
            };
            var food2 = new Food()
            {
                id = 2,
                name = "banana",
                age = 56
            };
            var food3 = new Food()
            {
                id = 3,
                name = "Mango",
                age = 34
            };

            List < Food > foodList= new List<Food>();
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            return View(foodList);
        }
        public IActionResult Details(int id)
        {
            var food1 = new Food()
            {
                id = id,
                name = "Jackfruit",
                age = 15
            };
            return View(food1);
        }
    }
}
