using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionPractise
{
    class Program
    {
       public static void Main(string[] args)
        {
            var assemblyName = Assembly.GetExecutingAssembly();
            var types = assemblyName.GetTypes();
            foreach(var type in types)
            {
                var myClass = Activator.CreateInstance(type);
                //Console.WriteLine(myClass);
                MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.DeclaredOnly | BindingFlags.Static);
                foreach (var method in methods)
                {
                    Console.WriteLine(method);
                    method.Invoke(myClass, null);
                }
                Console.WriteLine("From another class");
            }
            //var members = typeof(Person).GetMembers(BindingFlags.DeclaredOnly|BindingFlags.NonPublic|BindingFlags.Instance);
            //foreach (var member in members)
            //{
            //    Console.WriteLine(member.);

            //}
            //var person = new Person { Id = 1, Name = "Dipto", age = 27 };
           
         }
        
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int age;
            
            public void Print()
            {
                Console.WriteLine("This is awesome");
            }
            private void PrintHello()
            {
                Console.WriteLine("This is also awesome");
            }
            protected int Age()
            {
                Console.WriteLine("This is firy");
                return 1;
            }
        }
        //[AttributeUsage(AttributeTargets.Class)]
        //public class MyClassAttribute : Attribute { }
        //[AttributeUsage(AttributeTargets.Method)]
        //public class MyMethodAttribute : Attribute { }
    }
}
