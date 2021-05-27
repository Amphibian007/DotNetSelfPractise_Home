using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractise2
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age;
        private double salary = 200000;
        public void Print()
        {
            Console.WriteLine("This is awesome");
        }
        private void PrintHello()
        {
            Console.WriteLine("This is also awesome");
        }
        protected int ShowAge()
        {
            Console.WriteLine("This is firy");
            return 1;
        }
        static void CallMe()
        {
            Console.WriteLine("You have to call me");
        }
    }
}
