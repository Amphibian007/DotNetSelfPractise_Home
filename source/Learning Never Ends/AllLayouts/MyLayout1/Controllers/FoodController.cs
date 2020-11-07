using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLayout1.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult FoodIndex()
        {
            return View();
        }
    }
}
