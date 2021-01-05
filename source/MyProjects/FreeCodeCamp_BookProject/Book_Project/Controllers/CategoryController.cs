using Book_Project.DataAccessLayer;
using Book_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookDbContext _bookDb;
        public CategoryController(BookDbContext bookDb)
        {
            _bookDb = bookDb;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> bookList = _bookDb.Category;
            return View(bookList);
        }
    }
}
