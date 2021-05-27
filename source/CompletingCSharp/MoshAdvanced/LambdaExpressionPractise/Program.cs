using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = new BookRepository();
            var cheapBooks=br.books.FindAll(b => b.Price < 100);
            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Title);
            }
        }
       
    }
}
