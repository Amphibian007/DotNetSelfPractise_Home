using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public void Promote()
        {
            Console.WriteLine("You are promoted");
        }
    }
}
