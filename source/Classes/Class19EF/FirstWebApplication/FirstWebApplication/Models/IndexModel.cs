using FirstWebApplication.Code;
using Foundation.Contexts;
using Foundation.Entities;
using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Models
{
    public class IndexModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private readonly IEmailService _emailService;
        private readonly IMembershipService _membershipService;
        private readonly ShoppingContext _shoppingContext;

        public IndexModel(IEmailService emailService,
            IMembershipService membershipService, ShoppingContext context)
        {
            _emailService = emailService;
            _membershipService = membershipService;
            _shoppingContext = context;
        }

        public void Add()
        {
            _shoppingContext.Customers.Add(new Customer
            {
                Name = "Dipto Das",
                Email = "xyz@gmail.com",
                IsActive = true,
                Username = "diptodas", 
                Password = "something",
                PasswordSalt = "jdfjslkfjlsjf",
                RegisterDate = DateTime.Now
            });

            _shoppingContext.SaveChanges();
        }

        public void Update()
        {
            var customer = _shoppingContext.Customers.Where(x => x.Id == 1).FirstOrDefault();
            customer.Password = "Reg123";
            customer.IsActive = false;

            _shoppingContext.SaveChanges();
        }

        public void Delete()
        {
            var customer = _shoppingContext.Customers.Where(x => x.Id == 1).FirstOrDefault();

            _shoppingContext.Customers.Remove(customer);
            _shoppingContext.SaveChanges();
        }
    }
}
