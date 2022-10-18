using System.Globalization;

namespace PSI_MobileApp;

public class Converter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string EnumString = "";
        try
        {
            foreach (var item in (Array)value)
            {
                if (EnumString != "")
                {
                    EnumString += " ";
                }
                EnumString += item.ToString();
            }
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
