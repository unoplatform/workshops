using System;
using System.Collections;
using Windows.UI.Xaml.Data;
using Uno.Extensions.Specialized;

namespace TodoApp.Shared.Converters
{
    public class FromEnumerableToCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is IEnumerable enumerable)
            {
                var count = enumerable.Count();
                return count == 0 ? "" : $" ({count})";
            }
            else
                return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}