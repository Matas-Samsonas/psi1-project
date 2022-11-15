using ProfileClasses;
using System.Text.Json;

namespace ClassLibrary; 

public partial class Advertisement : IUsingUUID
{
    private Guid _id;
    private bool isReserved;
    private string mealName;
    private TimeSpan pickupTimeSpan;
    private Cuisines[] _tags;
    private TimeSpan timeOfMaking;
    private Distributor _distributor;
    private Profile _buyer;

    public virtual Distributor Distributor { get { return _distributor; } set { _distributor = value; } } 
    public virtual Profile Buyer { get { return _buyer; } set { _buyer = value; } }
    public bool IsReserved { get { return isReserved; } set { isReserved = value; } }
    public string MealName { get { return mealName; } set {mealName = value; } }
    public TimeSpan PickupTimeSpan { get { return pickupTimeSpan; } set {pickupTimeSpan = value; } }
    public string Tags { get { return JsonSerializer.Serialize(_tags); } set {_tags = JsonSerializer.Deserialize<Cuisines[]>(value); } }
    public TimeSpan TimeOfMaking { get { return timeOfMaking; } set { timeOfMaking = value; } }

    public Guid Id { get { return _id; } set { _id = value; } }
}
