using NextCRUD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextCRUD3.Repositories
{
    public static class FoodRepository
    {
        public static List<Food> myFoods = new List<Food>();
        public static IEnumerable<Food> showMyFoods
        {
            get { return myFoods; }
        }
        public static void Create(Food food1)
        {
            myFoods.Add(food1);
        }
    }
}
