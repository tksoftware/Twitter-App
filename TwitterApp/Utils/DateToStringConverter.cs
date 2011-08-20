using System;
using System.Globalization;
using System.Windows.Data;

namespace TwitterApp.Utils
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if (value is DateTime )
           {
               var date = (DateTime) value;

               var stringDate = date.ToString("dd.MM.yyyy HH.mm.ss");
               return stringDate;
               
           }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
