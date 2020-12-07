using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;

namespace Foundation.Repositoris
{
    class CategoryRepository : Repository<Category, int, MobileContext>, ICategoryRepository
    {
        public CategoryRepository(MobileContext context) : base(context)
        {
        }
    }
}
