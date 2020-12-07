using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foundation.Contexts;
using Foundation.Repositoris;
using Foundation.Services;
using Foundation.UnitOfWorks;

namespace MobilePhoneManagementApp
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
            builder.RegisterType<MobileContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<MobileRepository>().As<IMobileRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<MobileUnitOfWork>().As<IMobileUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<MobileService>().As<IMobileService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
