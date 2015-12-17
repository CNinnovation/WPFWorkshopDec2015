using System.Collections.Generic;
using BooksDemo.Models;

namespace BooksDemo.Repositories
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetTheBook();
    }
}