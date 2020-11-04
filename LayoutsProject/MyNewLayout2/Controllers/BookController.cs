using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyNewLayout2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookIndex()
        {
            return View();
        }
    }
}
