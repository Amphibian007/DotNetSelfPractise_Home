using NextCRUD2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextCRUD2.Repositories
{
    public static class GameRepository
    {
        public static List<Game> allGames = new List<Game>();
        public static IEnumerable<Game> showAllGames
        {
            get { return allGames; }
        }
        public static void Create(Game g1)
        {
            allGames.Add(g1);
        }
        public static void Delete(Game g1)
        {
            allGames.Remove(g1);
        }
    }
}
