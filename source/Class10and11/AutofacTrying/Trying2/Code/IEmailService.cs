using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trying2.Code
{
    public interface IEmailService
    {
        public void Send(string name, string body);
    }
}
