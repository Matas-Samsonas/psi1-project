namespace PSI_MobileApp;

public struct Address
{
    [ObservableProperty] 
    private string city;

    [ObservableProperty] 
    private string streetName;

    [ObservableProperty] 
    private int streetNumber;
}