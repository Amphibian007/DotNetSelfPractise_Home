using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfworks
{
    public class ShopingUnitOfWork : UnitOfWork, IShopingUnitOfWork
    {
        public IProductRepository ProductRepositroy { get; set; }
       
        public ShopingUnitOfWork(ShopingContext context, 
            IProductRepository productRepositroy)
            : base(context)
        {
            ProductRepositroy = productRepositroy;
            
        }
    }
}
