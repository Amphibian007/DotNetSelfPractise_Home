using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Foundation.Repositoris;

namespace Foundation.UnitOfWorks
{
    public interface IMobileUnitOfWork : IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; set; }
        IMobileRepository MobileRepository { get; set; }

    }
}
