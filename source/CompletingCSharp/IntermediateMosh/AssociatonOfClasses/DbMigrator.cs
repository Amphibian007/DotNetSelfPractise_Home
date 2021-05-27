using System;
using System.Collections.Generic;
using System.Text;

namespace AssociatonOfClasses
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are doing the migration");
        }
    }
}
