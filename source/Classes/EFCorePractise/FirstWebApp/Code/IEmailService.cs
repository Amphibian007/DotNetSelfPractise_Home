using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Code
{
    public interface IEmailService
    {
        void Send(string name, string body, string message);
    }
}
