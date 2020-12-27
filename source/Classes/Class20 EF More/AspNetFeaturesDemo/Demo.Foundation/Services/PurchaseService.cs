using Foundation.Entities;
using Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IShopingUnitOfWork _shopingUnitOfWork;
        public PurchaseService(IShopingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }

        public void Purchase(Product product, Customer customer)
        {
            _shopingUnitOfWork.ProductRepositroy.Remove(product);
            _shopingUnitOfWork.Save();
        }
        public IList<Product> GetProducts()
        {
            return _shopingUnitOfWork.ProductRepositroy.GetAll();
        }
        public void AddProduct(Product product)
        {
            _shopingUnitOfWork.ProductRepositroy.Add(product);
            _shopingUnitOfWork.Save();
        }
    }
}
