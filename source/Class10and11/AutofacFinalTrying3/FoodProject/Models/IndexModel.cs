using FoodProject.Code;
using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.Models
{
    public class IndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private readonly IFood _food;
        private readonly IMembershipService _membershipService;
        public IndexModel(IFood food, IMembershipService membershipService)
        {
            _food = food;
            _membershipService = membershipService;
        }
    }
}
