using Autofac;
using Foundation.Contexts;
using Foundation.Repositories;
using Foundation.Services;
using Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation
{
    public class FoundationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShopingContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName);
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ShopingUnitOfWork>().As<IShopingUnitOfWork>();
            builder.RegisterType<PurchaseService>().As<IPurchaseService>();

            base.Load(builder);
        }
    }
}
