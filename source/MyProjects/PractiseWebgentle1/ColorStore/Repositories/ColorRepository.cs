using ColorStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorStore.Repositories
{
    public class ColorRepository : IColorRepository
    {
        public List<ColorModel> GetAllColors()
        {
            return DataSource();
        }

        public ColorModel GetColorById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<ColorModel> SearchColor(string name,string price)
        {
            return DataSource().Where(x => x.Name.Contains(name) || x.Price.Contains(price)).ToList();
        }
        private List<ColorModel> DataSource()
        {
            return new List<ColorModel>(){
                new ColorModel(){Id=1,Name="Green",Price="High"},
                new ColorModel(){Id=2,Name="Blue",Price="High"},
                new ColorModel(){Id=3,Name="Red",Price="Low"}
            };
        }
    }
}
