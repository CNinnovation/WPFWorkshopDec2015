using BooksDemo.Models;
using BooksDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBooksDemo.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _repository;
        public BooksService(IBooksRepository repository)
        {
            _repository = repository;
        }

        private ObservableCollection<Book> _booksCache = new ObservableCollection<Book>();

        public IEnumerable<Book> GetBooks()
        {
            if (_booksCache.Count == 0)
            {
                var books = _repository.GetBooks();
                foreach (var b in books)
                {
                    _booksCache.Add(b);
                }
//                _booksCache.AddRange(books);
            }
            return _booksCache;
        }

        public Book AddBook(Book book)
        {
            _booksCache.Add(book);
            return book;
        }
    }
}
