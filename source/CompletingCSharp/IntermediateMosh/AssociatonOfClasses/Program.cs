using System;

namespace AssociatonOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var ins1 = new Installer(new Logger());
            var logger = new Logger();
            var dm1 = new DbMigrator(logger);
            ins1.Install();
            dm1.Migrate();
            
        }
    }
}
