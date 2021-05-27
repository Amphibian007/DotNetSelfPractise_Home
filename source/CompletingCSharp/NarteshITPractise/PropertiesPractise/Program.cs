using System;

namespace PropertiesPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(1, "Dipto", "Gazipur", false,1000,Cites.Dhaka,"Bangladesh");
            Console.WriteLine(c1.CustId);
            Console.WriteLine(c1.Name);
            Console.WriteLine(c1.Balance);
            c1.Balance -= 300;
            c1.City = Cites.Sylhet;
            Console.WriteLine(c1.City);
            Console.WriteLine(c1.Country);
        }
    }
}
