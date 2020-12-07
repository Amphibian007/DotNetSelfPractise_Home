using System;
using System.Collections.Generic;
using System.Text;
using Foundation.Entities;

namespace Foundation.Services
{
    public interface IMobileService
    {
        void AddMobile(Mobile mobile);
        void UpdateMobile(Mobile mobile);
        void GetByMobileId(int id);
        void RemoveMobileId(int id);
    }
}
