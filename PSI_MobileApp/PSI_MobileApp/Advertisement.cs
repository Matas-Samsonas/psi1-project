namespace PSI_MobileApp;


public partial class Advertisement : IUsingUUID, ObservableObject
{
    public string Uuid { get; set; }

    [ObservableProperty] 
    private bool isReserved;
    
    [ObservableProperty] 
    private string mealName;

    [ObservableProperty] 
    private string pickupTimeSpan;

    [ObservableProperty] 
    private Kitchen[] tags;

    [ObservableProperty] 
    private string timeOfMaking;
}
