using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote logic is changed");
        }
        
    }
}
