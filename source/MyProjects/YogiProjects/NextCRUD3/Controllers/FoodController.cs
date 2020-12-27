using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextCRUD3.Models;
using NextCRUD3.Repositories;

namespace NextCRUD3.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View(FoodRepository.showMyFoods);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Food fd1)
        {
            FoodRepository.Create(fd1);
            return View("Thanks", fd1);
        }
    }
}
