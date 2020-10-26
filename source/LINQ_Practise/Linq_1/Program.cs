using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Linq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Dipto");
            myList.Add("Pias");
            myList.Add("Sujan");
            myList.Add("Prokash");

            var names = from name in myList where name.Contains("p") select name;
            
            foreach(var item in names)
                Console.WriteLine(item);

                
        }
    }
}
