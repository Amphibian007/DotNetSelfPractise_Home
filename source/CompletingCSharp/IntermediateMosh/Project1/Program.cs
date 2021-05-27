using System;

namespace Project1
{
    public  class Person
    {
        string name;
        public void SayHello(string obj)
        {
            Console.WriteLine($"Hi {obj} this is {name}");
        }
        public static Person Parse(string obj)
        {
            var p1 = new Person();
            p1.name = obj;
            return p1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var em1 = new Employee(new DateTime(1994,01,17));
            Console.WriteLine(em1.Age);
        }
    }
}
