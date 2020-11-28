using Autofac;
using FirstWebApplication.Code;
using FirstWebApplication.Models;
using Foundation.Contexts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HtmlEmailService>().As<IEmailService>()
                .SingleInstance();

            builder.RegisterType<ShoppingContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName);

            builder.RegisterType<IndexModel>().AsSelf();

            base.Load(builder);
        }
    }
}
