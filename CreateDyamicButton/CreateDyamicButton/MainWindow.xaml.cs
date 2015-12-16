using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreateDyamicButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCreateAnotherButton(object sender, RoutedEventArgs e)
        {
            //            Button b = new Button() { Content = "a new one" };

            int i = 0;
            var b = new RepeatButton() { Content = i.ToString() };
            b.Click += (sender1, e1) =>
            {
                i = int.Parse(b.Content.ToString());
                i++;
                b.Content = i.ToString();
            };
            grid1.Children.Add(b);
            Grid.SetRow(b, 1);
        }
    }
}
