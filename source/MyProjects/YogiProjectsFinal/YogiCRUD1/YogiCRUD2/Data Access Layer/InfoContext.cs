using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YogiCRUD2.Models;

namespace YogiCRUD2.Data_Access_Layer
{
    public class InfoContext:DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {

        }
        DbSet<Information> Information { get; set; }

    }
}
