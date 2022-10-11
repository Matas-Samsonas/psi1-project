using System.Globalization;

namespace PSI_MobileApp;

public class EnumArrayToStringConverter : IValueConverter
{

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        //string newString = "";
        //foreach (var member in array)
        //{
        //    if (newString != String.Empty)
        //    {
        //        newString += ", ";
        //    }

        //    newString += member.ToString();
        //}

        //newString += ".";
        //return newString;
        throw new NotImplementedException();

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}