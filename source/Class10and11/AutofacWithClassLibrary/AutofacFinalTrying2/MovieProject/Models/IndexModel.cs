using Membership;
using MovieProject.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class IndexModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string ConfirmPasswd { get; set; }
        public string Password { get; set; }
        private readonly IMovie _movie;

        private readonly IMembershipService _membershipService;
        public IndexModel(IMovie movie, IMembershipService membershipService)
        {
            _movie = movie;
            _membershipService = membershipService;
        }
    }
}
