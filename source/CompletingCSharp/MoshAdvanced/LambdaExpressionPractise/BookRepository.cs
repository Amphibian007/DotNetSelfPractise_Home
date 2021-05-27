using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressionPractise
{
    public class BookRepository
    {
        public List<Book> books = new List<Book>
        {
            new Book{Title="ABC",Price=120},
            new Book{Title="DEF",Price=80},
            new Book{Title="XYZ",Price=50}
        };
    }
}
