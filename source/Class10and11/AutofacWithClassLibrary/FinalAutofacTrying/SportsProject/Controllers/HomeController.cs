using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Membership;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsProject.Code;
using SportsProject.Models;

namespace SportsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISport _sport;
        private readonly IMembershipService _membershipService;
        public HomeController(ILogger<HomeController> logger,ISport sport, IMembershipService membershipService)
        {
            _logger = logger;
            _sport = sport;
            _membershipService = membershipService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
