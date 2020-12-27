using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public interface IPurchaseService
    {
        void AddProduct(Product product);
        void Purchase(Product product, Customer customer);
        IList<Product> GetProducts();
    }
}
