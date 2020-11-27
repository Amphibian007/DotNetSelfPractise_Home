using FirstWebApp.Code;
using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class IndexModel
    {
        public string name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }
        private IEmailService _emailService;
        private IMembershipService _membershipService;
        private readonly ShoppingContext _shoppingContext;

        public IndexModel(IEmailService emailService, IMembershipService membershipService,ShoppingContext context)
        {
            _shoppingContext = context;
            _emailService = emailService;
            _membershipService = membershipService;
        }
        public void Add()
        {
            _shoppingContext.Customers.Add(new Customer
            {
                Name = "Dipto",
                Email = "d@dgamil.com",
                IsActive = true,
                Password="something",
                PasswordSalt="trewrtt",
                RegisterDate=DateTime.Now
            }); 
            _shoppingContext.SaveChanges();
        }

        public void Update()
        {
           var customer= _shoppingContext.Customers.Where(x => x.Id == 1).FirstOrDefault();
            customer.Password = "iipppui";
            customer.IsActive = false;
            customer.Username = "Drac_007";
            _shoppingContext.SaveChanges();
        }

    }
}
