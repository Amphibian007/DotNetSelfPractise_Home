using AnimalProject.Code;
using Contracts;
using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalProject.Models
{
    public class IndexModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private readonly IAnimal _animal;

        private readonly IMembershipService _membershipService;

        private readonly IInternshipService _internshipService;

        public IndexModel(IAnimal animal, IMembershipService membershipService,IInternshipService internshipService)
        {
            _animal = animal;
            _membershipService = membershipService;
            _internshipService = internshipService;
        }
    }
}
