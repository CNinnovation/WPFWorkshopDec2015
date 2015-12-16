using BooksDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDemo.Repositories
{
    public class BooksRepository
    {
        public Book GetTheBook() =>
            new Book { Title = "Professional C# 5.0", Publisher = "Wrox Press" };

    }
}
