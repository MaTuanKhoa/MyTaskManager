using System.Globalization;

namespace MauiTaskManager.Converters;

public class SummaryMultiConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values == null || values.Length < 2)
            return "Completed: 0 / Total: 0";

        int completed = 0;
        int total = 0;

        if (values[0] is int c)
            completed = c;

        if (values[1] is int t)
            total = t;

        return $"Completed: {completed} / Total: {total}";
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
