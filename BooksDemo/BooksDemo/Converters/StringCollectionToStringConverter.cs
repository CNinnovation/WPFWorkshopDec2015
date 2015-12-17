using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BooksDemo.Converters
{
    [ValueConversion(typeof(IEnumerable<string>), typeof(string))]
    public class StringCollectionToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<string> names = value as IEnumerable<string>;
            if (names == null) return null;
            return string.Join(parameter?.ToString() ?? "..", names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
