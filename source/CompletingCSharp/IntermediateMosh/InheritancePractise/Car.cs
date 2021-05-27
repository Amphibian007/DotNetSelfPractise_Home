using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractise
{
    public class Car:Vehicle
    {
        public Car(string registrationNumber):base(registrationNumber)
        {
            Console.WriteLine("Car is initiated" +registrationNumber);
        }
    }
}
