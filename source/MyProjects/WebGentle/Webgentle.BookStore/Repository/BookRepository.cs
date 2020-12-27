using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public IList<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public IList<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title)|| x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "Feluda", Author = "Satyajit",Description="Detective book",Category="Detective",TotalPages=100,Language="Bengali" },
                new BookModel() { Id = 2, Title = "Sherlock", Author = "Aurthor Konan Doyal",Description="Detective Book" ,Category="Detective",TotalPages=100,Language="Bengali"},
                new BookModel() { Id = 3, Title = "Food", Author = "Me",Description="Food related book",Category="Detective",TotalPages=100,Language="English" },
                new BookModel() { Id = 4, Title = "The Enlightened One", Author = "Dipto",Description="Autobiography",Category="Detective",TotalPages=100,Language="Bengali" },
                new BookModel() { Id = 5, Title = "C#", Author = "Nikolov",Description="Programming",Category="Detective",TotalPages=100,Language="Bengali"},
                new BookModel() { Id = 6, Title = "Asp.net", Author = "Me",Description="Development",Category="Detective",TotalPages=100,Language="Bengali"},
            };
        }
    }
}
