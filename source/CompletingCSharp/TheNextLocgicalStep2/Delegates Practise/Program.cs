using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Practise
{
    //public  delegate bool Filters(string name);
    //public delegate int GetLength(string name);
    class Program
    {

        static void Main(string[] args)
        {
            string[] names = { "Dipto", "Pias", "Sujon", "As", "It", "Is","Awesome","Finally" };
            //Func<string, bool> lessThanFive = LessThanFive;
            List<string> showNames = NumberFilter(names, LessThanFive);
            Console.WriteLine(string.Join(",",showNames));
            Console.WriteLine(new string('-',50));
            List<string> showNames2 = NumberFilter(names, ExactlyFive);
            Console.WriteLine(string.Join(",",showNames2));
            List<string> showNames3 = NumberFilter(names, x=>x.Length>5);
            Console.WriteLine(string.Join(",", showNames3));
            Console.WriteLine();
            Action<string> helloThere = HelloName;
            helloThere += HelloName;
            helloThere.Invoke("Dipto");
        }
        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }
        public static bool LessThanFive(string name)
        {
            return name.Length < 5;
        }
        public static bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }
        public static List<string> NumberFilter(string[] names, Predicate<string>filter)
        {
            List<string> myNames = new List<string>();
            foreach(var name in names)
            {
                if (filter(name))
                {
                    myNames.Add(name);
                }
            }
            return myNames;

        }
        public static void HelloName(string message)
        {
            Console.WriteLine($"Hello {message}");
        }
        public static List<T> GottaCatchEmAll<T> (Delegate del, Object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                              .Select(d =>(T) d.DynamicInvoke(parameter)).ToList();
            return result;
        }
    }
}
