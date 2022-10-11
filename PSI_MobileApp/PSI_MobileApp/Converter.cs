namespace PSI_MobileApp;

public static class Converter : IValueConverter
{
    public static string ArrayToString(this Array array)
    {
        string newString = "";
        foreach (var member in array)
        {
            if (newString != String.Empty)
            {
                newString += ", ";
            }

            newString += member.ToString();
        }

        newString += ".";
        return newString;
    }
}
