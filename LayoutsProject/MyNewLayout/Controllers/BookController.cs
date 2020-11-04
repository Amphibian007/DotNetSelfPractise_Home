using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyNewLayout.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookIndex(int id)
        {
            return View(id);
        }
    }
}
