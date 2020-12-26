using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFPractise.DataAccessLayer;
using EFPractise.Interfaces;
using EFPractise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFPractise.Controllers
{
    [Route("api/[Controller]")]
    public class BooksController : Controller
    {
        private readonly IBookRepository _books;
        public BooksController(IBookRepository books)
        {
            _books = books;  
        }
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _books.GetAllBooksAsync());
        }
        [Route("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            return Ok(await _books.GetBookByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            
            return Ok(await _books.CreateBookAsync(book));
        }

    }
}
