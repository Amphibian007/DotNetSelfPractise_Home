using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryingAutofac.Code
{
    public interface IEmailService
    {
        void Email(string subject, string body, string email);
    }
}
