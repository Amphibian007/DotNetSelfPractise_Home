using System;

namespace DIPractise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new StudentBL();
            var myStudents = student.GetStudents();
            foreach(var item in myStudents)
                Console.WriteLine($"{item.Id} and {item.Name}");
        }
    }
}
