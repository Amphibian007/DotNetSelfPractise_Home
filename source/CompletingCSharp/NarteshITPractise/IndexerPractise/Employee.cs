using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerPractise
{
    public class Employee
    {
        int EmployeeId;
        string Name;
        string Address;
        public Employee(int employeeId, string name, string address)
        {
            EmployeeId = employeeId;
            Name = name;
            Address = address;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return EmployeeId;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Address;
                    return null;
            }
            set
            {
                if (index == 0)
                    EmployeeId = (int)value;
                else if (index == 1)
                {
                    Name = (string)value;
                }
                else if (index == 2)
                {
                    Address = (string)value;
                }
            }
        }

    }
}
   
