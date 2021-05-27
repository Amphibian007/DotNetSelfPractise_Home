using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\Hp\\OneDrive\\Desktop\\Projects\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
