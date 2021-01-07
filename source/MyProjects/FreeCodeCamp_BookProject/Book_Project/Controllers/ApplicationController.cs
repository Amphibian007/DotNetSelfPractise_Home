using Book_Project.DataAccessLayer;
using Book_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Project.Controllers
{
    public class ApplicationController : Controller
    {
        public readonly BookDbContext _applicationDb;
        public ApplicationController(BookDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            IEnumerable<Application> appList = _applicationDb.Application;
            return View(appList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Application obj)
        {
            _applicationDb.Add(obj);
            _applicationDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
