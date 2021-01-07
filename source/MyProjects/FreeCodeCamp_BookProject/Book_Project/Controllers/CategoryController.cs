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
        //Get--Create
        public IActionResult Create()
        {
            return View();
        }
        //Post--Create
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _bookDb.Add(obj);
                _bookDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _bookDb.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post--Edit
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _bookDb.Update(obj);
                _bookDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get Delte
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _bookDb.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post--Delete
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var obj = _bookDb.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
           
                _bookDb.Remove(obj);
                _bookDb.SaveChanges();
                return RedirectToAction("Index");
            
          
        }





    }
}
