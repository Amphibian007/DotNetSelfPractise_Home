using System;
using System.Collections.Generic;
using System.Text;
using Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Contexts
{
    public interface IMobileContext
    {
        DbSet<Mobile> Mobiles { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<MobileCategory> MobilesCategorys { get; set; }
    }
}
