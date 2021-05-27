using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesPractise
{
    public class Customer
    {
        int _CustId;
        string _Name;
        string _District;
        bool _Status;
        double _Balance;
        Cites _City;
        public Customer(int CustId, string Name, string District, bool Status, double Balance,Cites City,string Country)
        {
            _CustId = CustId;
            _Name = Name;
            _District = District;
            _Status = Status;
            _Balance = Balance;
            _City = City;
            this.Country = Country;
        }
        public int CustId
        {
            get { return _CustId; }
            set
            {
                _CustId = value;
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public double Balance
        {
            get
            {
                if (_Balance > 500)
                {
                    return _Balance;
                }
                else
                {
                    return 0;
                }
              
            }
            set
            {
                if (_Balance > 500)
                {
                    _Balance = value;
                }
            }
        }

        public Cites City
        {
            get { return _City; }
            set
            {
                if(_Status==true)
                _City = value;
            }
        }
        public string Country { get; set; }

    }
}
