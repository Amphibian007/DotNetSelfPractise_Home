using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextCRUD2.Services
{
    public class TotalUsers
    {
        public int UserNO()
        {
            var rand = new Random();
            return rand.Next(1,100000);
        }
    }
}
