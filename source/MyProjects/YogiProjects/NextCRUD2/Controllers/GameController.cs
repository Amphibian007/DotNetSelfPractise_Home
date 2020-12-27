using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextCRUD2.Models;
using NextCRUD2.Repositories;

namespace NextCRUD2.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View(GameRepository.showAllGames);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Game game1)
        {
            GameRepository.Create(game1);
            return View("Thanks", game1);
        }
        public IActionResult Update(string gameName)
        {
            var game=GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault();
            return View(game);
        }
        [HttpPost]
        public IActionResult Update(Game game, string gameName)
        {
           GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault().Id = game.Id;
           GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault().Name = game.Name;
           GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault().Difficulty = game.Difficulty;
           GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault().Type = game.Type;
           GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault().Rate = game.Rate;
           return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(string gameName)
        {
            var gameToDelete = GameRepository.allGames.Where(g => g.Name == gameName).FirstOrDefault();
            GameRepository.Delete(gameToDelete);
            return RedirectToAction("Index");
        }
    }
}
