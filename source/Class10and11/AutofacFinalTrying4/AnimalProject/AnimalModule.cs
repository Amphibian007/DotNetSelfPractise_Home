using AnimalProject.Code;
using AnimalProject.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class AnimalModule:Module
    {
            private readonly string _connectionString;
            private readonly string _migrationAssemblyName;

            public AnimalModule(string connectionString, string migrationAssemblyName)
            {
                _connectionString = connectionString;
                _migrationAssemblyName = migrationAssemblyName;
            }

            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<AnimalService>().As<IAnimal>();
                builder.RegisterType<IndexModel>().AsSelf();
                base.Load(builder);
            }
        }
}
