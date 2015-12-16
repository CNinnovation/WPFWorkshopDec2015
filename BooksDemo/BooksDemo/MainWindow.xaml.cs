using BooksDemo.Models;
using BooksDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book _theBook;
        public MainWindow()
        {
            InitializeComponent();
            _theBook = new BooksRepository().GetTheBook();
            this.DataContext = _theBook;
        }

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_theBook.Title, _theBook.Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            _theBook.Title = "Professional C# 6";
        }
    }
}
