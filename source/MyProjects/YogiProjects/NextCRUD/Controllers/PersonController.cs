using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextCRUD.Models;
using NextCRUD.Repositories;

namespace NextCRUD.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View(PersonRepository.showAllPersons);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person1)
        {
            PersonRepository.Create(person1);
            return View("Thanks", person1);
        }
        public IActionResult Update(string personName)
        {
            var person = PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault();
            return View(person);
        }
        [HttpPost]
        public IActionResult Update(Person person,string personName)
        {
            PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault().Id = person.Id;
            PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault().Name = person.Name;
            PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault().Occupation = person.Occupation;
            PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault().Gender = person.Gender;
            PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault().Area = person.Area;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(string personName)
        {
           var personToDelete= PersonRepository.allPersons.Where(p => p.Name == personName).FirstOrDefault();
            PersonRepository.Delete(personToDelete);
            return RedirectToAction("Index");
        }
    }
}
