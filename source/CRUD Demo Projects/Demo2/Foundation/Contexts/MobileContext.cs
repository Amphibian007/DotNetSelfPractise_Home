using System;
using System.Collections.Generic;
using System.Text;
using Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Contexts
{
    public class MobileContext : DbContext, IMobileContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public MobileContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MobileCategory>()
                .HasOne<Mobile>(sc => sc.Mobile)
                .WithMany(s => s.Categories)
                .HasForeignKey(sc => sc.MobileId);

            builder.Entity<MobileCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.Categories)
                .HasForeignKey(sc => sc.CategoryId);

            base.OnModelCreating(builder);
        }

        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MobileCategory> MobilesCategorys { get; set; }
    }
}
