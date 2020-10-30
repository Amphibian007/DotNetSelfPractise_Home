using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Membership
{
    public class MembershipModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public MembershipModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MembershipService>().As<IMembershipService>();
            base.Load(builder);
        }
    }
}
