﻿using BooksDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BooksDemo
{
    public class BookTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultBookTemplate { get; set; }
        public DataTemplate WroxBookTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate selectedTemplate = null;

            Book book = item as Book;
            if (book != null)
            {
                switch (book.Publisher)
                {
                    case "Wrox Press":
                        selectedTemplate = WroxBookTemplate;
                        break;
                    default:
                        selectedTemplate = DefaultBookTemplate;
                        break;
                }
            }
            return selectedTemplate;
        }
    }
}
