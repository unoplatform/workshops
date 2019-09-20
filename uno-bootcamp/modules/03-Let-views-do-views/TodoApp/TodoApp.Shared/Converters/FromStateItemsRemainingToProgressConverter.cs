using System;
using Windows.UI.Xaml.Data;
using TodoApp.Shared.Models;

namespace TodoApp.Shared.Converters
{
    public class FromStateItemsRemainingToProgressConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is State state)
            {
                var total = state.Todos.Length;

                if (total == 0) return 0; // prevent a division by zero

                var remaining = state.RemainingTodos;

                if (remaining == 0) return 100; // prevent useless calculation

                var completedRatio = (double) (total - remaining) / total;
                var percentComplete = (int) Math.Round(100.0d * completedRatio);

                return percentComplete;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}