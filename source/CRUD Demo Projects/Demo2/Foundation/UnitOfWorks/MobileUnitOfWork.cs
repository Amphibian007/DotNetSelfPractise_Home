using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Repositoris;
using Microsoft.EntityFrameworkCore;

namespace Foundation.UnitOfWorks
{
    public class MobileUnitOfWork : UnitOfWork, IMobileUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public IMobileRepository MobileRepository { get; set; }
        public MobileUnitOfWork(MobileContext mobileContext, ICategoryRepository categoryRepository, IMobileRepository mobileRepository)
            : base(mobileContext)
        {
            CategoryRepository = categoryRepository;
            MobileRepository = mobileRepository;
        }
    }
}
