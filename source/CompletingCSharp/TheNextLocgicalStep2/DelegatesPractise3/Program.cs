using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int,int,bool> IsGreater = (num1,num2) => num1 >num2 ;
            //Console.WriteLine(IsGreater(8,5));
            //Action printName = ()=> Console.WriteLine("this is awesome");
            //printName();
            //Action<int, int> SumOfNumbers = (i, j) =>
            // {
            //     Console.WriteLine($"First number is {i} ");
            //     Console.WriteLine($"Second number is {j} ");
            //     Console.WriteLine($"The sum is {i+j}");
            // };
            //SumOfNumbers(5, 4);

            string[] names = { "Dipto", "Pias", "Prokash", "Neropama", "As", "If", "It", "Was", "Awesome" };
            Func<string[], Func<string, bool>, List<string>> filterNames = (myNames, filter) =>
               {
                   List<string> showNames = new List<string>();
                   foreach(var name in myNames)
                   {
                       if (filter(name))
                       {
                           showNames.Add(name);
                       }
                   }
                   return showNames;
               };
            Func<string,bool> MoreThanFive= n => n.Length > 5;
            Func<string, bool> ExactlyFive = n => n.Length == 5;
            Func<string, bool> LessThanFive = n => n.Length < 5;
            Console.WriteLine(string.Join(",",filterNames(names,MoreThanFive)));
            Console.WriteLine(string.Join(",", filterNames(names, ExactlyFive)));
            Console.WriteLine(string.Join(",",filterNames(names,LessThanFive)));
            var input = Console.ReadLine();
            Console.WriteLine(IsInteger(input));
        }
        public static bool IsInteger(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])==false)
                    return false;
                
            }
            return true;
        }
    }
}
