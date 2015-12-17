using System.Collections.Generic;
using BooksDemo.Models;

namespace MVVMBooksDemo.Services
{
    public interface IBooksService
    {
        Book AddBook(Book book);
        IEnumerable<Book> GetBooks();
    }
}