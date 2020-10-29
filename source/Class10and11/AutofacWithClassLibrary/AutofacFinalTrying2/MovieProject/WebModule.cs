using Autofac;
using MovieProject.Code;
using MovieProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject
{
    public class WebModule:Module
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
            builder.RegisterType<MovieImplement>().As<IMovie>().SingleInstance();
            builder.RegisterType<IndexModel>().AsSelf();
            base.Load(builder);
        }
    }
}
