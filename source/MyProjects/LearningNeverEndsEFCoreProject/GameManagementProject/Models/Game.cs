using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameManagementProject.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
    }
}
