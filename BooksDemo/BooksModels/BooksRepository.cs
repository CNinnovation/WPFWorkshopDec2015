using BooksDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDemo.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        //public Book GetTheBook() =>
        //    new Book { Title = "Professional C# 5.0", Publisher = "Wrox Press" };

        public Book GetTheBook() =>
            new Book("Professional C# 5.0", "Wrox Press", "Christian Nagel", "Morgan Skinner", "Jay Glynn");

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book("Professional C# 5.0", "Wrox Press", "Christian Nagel", "Morgan Skinner", "Jay Glynn"),
                new Book("Professional C# 6", "Wrox Press", "Christian Nagel"),
                new Book("Enterprise Services", "Addison Wesley", "Christian Nagel")
            };
    }
}
