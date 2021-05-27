using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractise
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is initialized" +registrationNumber);
        }

      
    }
}
