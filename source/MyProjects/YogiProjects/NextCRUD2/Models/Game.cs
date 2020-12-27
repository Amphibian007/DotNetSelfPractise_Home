using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextCRUD2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public char Rate { get; set; }
    }
}
