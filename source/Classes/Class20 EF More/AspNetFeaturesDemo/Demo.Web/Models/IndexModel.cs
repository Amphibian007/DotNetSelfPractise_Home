using Foundation.Contexts;
using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        
        private readonly IPurchaseService _purchaseService;

        public IndexModel(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        public void Add()
        {
            _purchaseService.Purchase(new Product
            {
                Name = "Test Product",
                Price = 23
            },
            new Customer
            {
                Name = "Jalal uddin",
                Email = "xyz@gmail.com",
                IsActive = true,
                Username = "jalaluddin",
                Password = "something",
                PasswordSalt = "jdfjslkfjlsjf",
                RegisterDate = DateTime.Now
            });
        }
    }
}
