using System;

namespace DipendencyInjectionPractise
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL1 = new EmployeeBL();
            var myEmployees=employeeBL1.GetEmployees();
            foreach(var item in myEmployees)
                Console.WriteLine($"Id is {item.Id} and Name is {item.Name}");
        }
    }
}
