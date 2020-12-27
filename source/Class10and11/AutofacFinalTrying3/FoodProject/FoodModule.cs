using Autofac;
using FoodProject.Code;
using FoodProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject
{
    public class FoodModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoodModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FoodDelivery>().As<IFood>().SingleInstance();

            builder.RegisterType<ShoppingContext>()
             .WithParameter("connectionString", _connectionString)
             .WithParameter("migrationAssemblyName", _migrationAssemblyName);

            builder.RegisterType<IndexModel>().AsSelf();
            base.Load(builder);
        }
    }
}
