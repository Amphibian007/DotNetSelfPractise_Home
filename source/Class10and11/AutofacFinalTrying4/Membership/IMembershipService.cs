using System;
using System.Collections.Generic;
using System.Text;

namespace Membership
{
    public interface IMembershipService
    {
         void GiveService(string name, string email, string password);
    }
}
