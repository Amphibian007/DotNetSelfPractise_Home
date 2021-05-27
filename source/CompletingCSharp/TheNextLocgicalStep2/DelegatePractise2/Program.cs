using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractise2
{
    public delegate void Printer(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = Print;
            p += Print;
            p += PrintTwice;
            var types = p.GetInvocationList();
            foreach(var type in types)
                Console.WriteLine(type.Method);
            p.Invoke("this is awesome");
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintTwice(string message)
        {
            Console.WriteLine(message+"1");
            Console.WriteLine(message+"2");
        }
    }
}
