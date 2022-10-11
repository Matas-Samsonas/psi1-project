using CommunityToolkit.Mvvm.ComponentModel;

namespace PSI_MobileApp;

public struct Address
{
    [ObservableProperty]
    public string city;

    [ObservableProperty]
    public string streetName;

    [ObservableProperty]
    public int streetNumber;
}