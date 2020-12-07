using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;

namespace Foundation.Repositoris
{
    public class MobileRepository : Repository<Mobile, int, MobileContext>, IMobileRepository
    {
        public MobileRepository(MobileContext context) : base(context)
        {
        }
    }
}
