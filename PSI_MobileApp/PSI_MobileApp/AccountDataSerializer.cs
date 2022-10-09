using Newtonsoft.Json;
// ReSharper disable StringCompareIsCultureSpecific.1
namespace AccountDataSerializer;

using ProfileClasses;
using PSI_MobileApp;

public class AccountDataSerializer<t> where t : class, IUsingUUID
{
    private string path;
    private LinkedList<t> list;
    public void Add(t newInstance)
    {
        list.AddLast(newInstance);
        Reserialize();
    }

    private LinkedList<t> GetList()
    {
        if (!File.Exists(path))
        {
            using (File.Create(path)) { }
        }

        return JsonConvert.DeserializeObject<LinkedList<t>>(File.ReadAllText(path));
    }

    public t GetById(string id)
    {
        foreach (var instance in list)
        {
            if (string.Compare(instance.Uuid, id) == 0)
            {
                return instance;
            }
        }

        return null;
    }
    public void Delete(t instanceToDelete)
    {
        list.Remove(instanceToDelete);
        Reserialize();
    }

    public void Reserialize()
    {
        File.WriteAllText(path, JsonConvert.SerializeObject(list));
    }

    public AccountDataSerializer (string path)
    {
        this.path = path;
        this.list = GetList();
    }
}