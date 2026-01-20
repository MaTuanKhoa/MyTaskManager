using System.Globalization;

namespace MauiTaskManager.Converters;

public class PreviewTextConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool completed = (bool)value;
        return completed ? TextDecorations.Strikethrough : TextDecorations.None;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
