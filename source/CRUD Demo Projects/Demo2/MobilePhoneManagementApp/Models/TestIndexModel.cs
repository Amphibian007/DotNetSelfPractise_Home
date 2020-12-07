using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foundation.Entities;
using Foundation.Services;

namespace MobilePhoneManagementApp.Models
{
    public class TestIndexModel
    {
        private readonly IMobileService _mobileService;

        public TestIndexModel(IMobileService mobileService)
        {
            _mobileService = mobileService;
        }

        public void Add(Mobile mobile)
        {
            _mobileService.AddMobile(mobile);
        }



    }
}
