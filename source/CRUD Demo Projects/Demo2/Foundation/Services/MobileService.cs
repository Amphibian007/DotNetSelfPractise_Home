using System;
using System.Collections.Generic;
using System.Text;
using Foundation.Entities;
using Foundation.UnitOfWorks;

namespace Foundation.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileUnitOfWork _mobileUnitOfWork;

        public MobileService(IMobileUnitOfWork mobileUnitOfWork)
        {
            _mobileUnitOfWork = mobileUnitOfWork;
        }
        public void AddMobile(Mobile mobile)
        {
            _mobileUnitOfWork.MobileRepository.Add(mobile);
            _mobileUnitOfWork.Save();
        }
        public void UpdateMobile(Mobile mobile)
        {
            _mobileUnitOfWork.MobileRepository.Edit(mobile);
            _mobileUnitOfWork.Save();
        }
        public void GetByMobileId(int id)
        {
            _mobileUnitOfWork.MobileRepository.GetById(id);
        }

        public void RemoveMobileId(int id)
        {
            _mobileUnitOfWork.MobileRepository.Remove(id);
        }
    }
}
