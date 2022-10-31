using CommunityToolkit.Mvvm.ComponentModel;

namespace PSI_MobileApp;


public partial class Advertisement : ObservableObject
{

    [ObservableProperty]
    private bool isReserved;

    [ObservableProperty]
    private string mealName;

    [ObservableProperty]
    private TimeSpan pickupTimeSpan;

    [ObservableProperty]
    private Cuisines[] tags;

    [ObservableProperty]
    private TimeSpan timeOfMaking;
}
