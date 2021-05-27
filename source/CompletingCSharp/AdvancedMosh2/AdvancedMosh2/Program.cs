using System;
using System.Linq;

namespace AdvancedMosh2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.Skip(1).Take(2);
            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
