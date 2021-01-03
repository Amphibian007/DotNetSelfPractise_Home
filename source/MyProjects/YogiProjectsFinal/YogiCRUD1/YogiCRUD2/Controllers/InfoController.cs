using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YogiCRUD2.Data_Access_Layer;
using YogiCRUD2.Models;

namespace YogiCRUD2.Controllers
{
    public class InfoController : Controller
    {
        private readonly ILogger<InfoController> _logger;
        private readonly InfoContext _infoContext;
        public InfoController(ILogger<InfoController> logger, InfoContext infoContext)
        {
            _infoContext = infoContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Information info)
        {
            _infoContext.Entry(info).State = EntityState.Added;
            _infoContext.SaveChanges();
            return View("Thanks");
        }
    }
}
