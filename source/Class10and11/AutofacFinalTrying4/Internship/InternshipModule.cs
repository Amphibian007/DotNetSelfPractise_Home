using Autofac;
using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship
{
    public class InternshipModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InternshipModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InternshipService>().As<IInternshipService>();
            base.Load(builder);
        }
    }
}
