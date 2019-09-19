using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace TodoApp.Shared.Converters
{
    public class FromBooleanToDoubleConverter : IValueConverter
    {
        public double TrueValue { get; } = 0.5;
        public double FalseValue { get; } = 1;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool boolValue) return boolValue ? TrueValue : FalseValue;

            return System.Convert.ToBoolean(value, CultureInfo.InvariantCulture) ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}