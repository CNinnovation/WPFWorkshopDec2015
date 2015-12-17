
using BooksDemo.Models;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using MVVMBooksDemo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MVVMBooksDemo.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly IBooksService _booksService;
        private readonly ObservableCollection<Book> _books;
        public MainPageViewModel(IBooksService booksService)
        {
            _booksService = booksService;
            AddBookCommand = new DelegateCommand(OnAddBook);
            _books = new ObservableCollection<Book>(_booksService.GetBooks());
            SelectedBook = _books.First();
            ICollectionView cv = CollectionViewSource.GetDefaultView(_books);
            
        }

        public DelegateCommand AddBookCommand { get; }

        public IEnumerable<Book> Books => _books;

        public void OnAddBook()
        {
            Book book = _booksService.AddBook(new Book { Title = "sample book", Publisher = "self" });
            _books.Add(book);
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }
    }
}
