using DataAccessLayer;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfworks
{
    public interface IShopingUnitOfWork : IUnitOfWork
    {
        IProductRepository ProductRepositroy { get; set; }
       
    }
}
