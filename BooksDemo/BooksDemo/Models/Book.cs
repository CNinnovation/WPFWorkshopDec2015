using AnotherSuperCoolFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDemo.Models
{
    public class Book : BindableBase
    {
        public Book()
            : this("unknown", "unknown", "unknown")
        {

        }

        public Book(string title, string publisher, params string[] authors)
        {
            _title = title;
            _publisher = publisher;
            Authors = new List<string>(authors);
        }

        //public string Title { get; set; }
        //public string Publisher { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set
            {
                SetProperty(ref _publisher, value);
            }
        }

        public IEnumerable<string> Authors { get; }



        public override string ToString() => Title;  // expression bodied member
    }
}
