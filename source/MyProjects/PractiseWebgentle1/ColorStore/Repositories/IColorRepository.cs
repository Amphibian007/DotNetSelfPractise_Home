using ColorStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorStore.Repositories
{
    public interface IColorRepository
    {
        public List<ColorModel> GetAllColors();
        public ColorModel GetColorById(int Id);
        public List<ColorModel> SearchColor(string name, string price);

    }
}
