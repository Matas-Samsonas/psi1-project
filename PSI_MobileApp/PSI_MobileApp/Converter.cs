using System.Globalization;

namespace PSI_MobileApp;

public class Converter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string EnumString;
        try
        {
            EnumString = Enum.GetName(value.GetType(), value);
            return EnumString;
        }
        catch
        {
            return String.Empty;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}