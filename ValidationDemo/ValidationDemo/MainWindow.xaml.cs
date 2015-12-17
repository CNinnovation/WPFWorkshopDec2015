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

namespace ValidationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SomeData _someData;
        public MainWindow()
        {
            InitializeComponent();
            _someData = new SomeData() { Val1 = 1, Val2 = 1 };
            this.DataContext = _someData;
        }

        private void OnShowValue(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"val1: {_someData.Val1}, val2: {_someData.Val2}");
        }
    }
}
