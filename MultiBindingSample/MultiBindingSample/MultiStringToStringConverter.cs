using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBindingSample
{
    public class MultiStringToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string firstName = values[0].ToString();
            string lastName = values[1].ToString();

            string option = parameter.ToString();
            if (option == "FirstLast")
            {
                return $"{firstName} {lastName}";
            }
            else if (option == "LastFirst")
            {
                return $"{lastName}, {firstName}";
            }
            return "unknown option";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
