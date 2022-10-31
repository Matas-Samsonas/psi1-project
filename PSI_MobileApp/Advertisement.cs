

namespace PSI_MobileApp;


public partial class Advertisement 
{
    private bool isReserved;
    private string mealName;
    private TimeSpan pickupTimeSpan;
    private Cuisines[] tags;
    private TimeSpan timeOfMaking;

    public bool IsReserved { get { return isReserved; } set { isReserved = value; } }
    public string MealName { get { return mealName; } set {mealName = value; } }
    public TimeSpan PickupTimeSpan { get { return pickupTimeSpan; } set {pickupTimeSpan = value; } }
    public Cuisines[] Tags { get { return tags; } set {tags = value; } }
    public TimeSpan TimeOfMaking { get { return timeOfMaking; } set { timeOfMaking = value; } }

}
