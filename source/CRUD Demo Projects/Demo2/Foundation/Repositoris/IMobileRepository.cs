﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;

namespace Foundation.Repositoris
{
    public interface IMobileRepository : IRepository<Mobile, int, MobileContext>
    {
    }
}
