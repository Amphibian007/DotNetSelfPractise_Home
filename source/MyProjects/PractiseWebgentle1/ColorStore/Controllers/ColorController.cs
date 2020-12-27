using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorStore.Models;
using ColorStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ColorStore.Controllers
{
    public class ColorController : Controller
    {
        private readonly ColorRepository _colorRepository=null;
        public ColorController()
        {
            _colorRepository = new ColorRepository();
        }
        public List<ColorModel> GetColors()
        {
           return _colorRepository.GetAllColors();         
        }
        public ColorModel GetColorById(int id)
        {
            return _colorRepository.GetColorById(2);
        }
        public List<ColorModel> SearchColor(string name, string price)
        {
            return _colorRepository.SearchColor(name,price);
        }
    }
}
