using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Code
{
    public interface IEmailService
    {
        void Send(string subject, string body, string email);
    }
}
