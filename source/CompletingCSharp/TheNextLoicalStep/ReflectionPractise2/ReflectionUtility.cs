using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractise2
{
    public class ReflectionUtility
    {
        public void InvokeMethods()
        {
            var methods = typeof(Person).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.DeclaredOnly | BindingFlags.Static);
            foreach(var method in methods)
            {
                Console.WriteLine(method.Name);
                method.Invoke(new Person(), null);
            }
        }
    }
}
