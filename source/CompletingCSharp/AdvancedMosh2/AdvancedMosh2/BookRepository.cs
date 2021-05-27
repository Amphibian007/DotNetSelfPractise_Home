using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedMosh2
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title="abc",Price=67},
                new Book{Title="def",Price=89},
                new Book{Title="ghi",Price=100},
                new Book{Title="mno",Price=120}
            };

        }
    }
}
