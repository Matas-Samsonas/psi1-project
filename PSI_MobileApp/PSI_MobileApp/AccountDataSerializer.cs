using System.Collections.ObjectModel;
using Newtonsoft.Json;
// ReSharper disable StringCompareIsCultureSpecific.1
namespace AccountDataSerializer;

using ProfileClasses;
using ConsoleApp1;

public class AccountDataSerializer<T> where T : class, IUsingUUID
{
    private string _path;
    private Collection<T> _list;
    public void Add(T newInstance)
    {
        _list.Add(newInstance);
        Reserialize();
    }

    private Collection<T> GetList()
    {
        if (!File.Exists(_path))
        {
            using (File.Create(_path)) { }
        }

        return JsonConvert.DeserializeObject<Collection<T>>(File.ReadAllText(_path));
    }

    public T GetFirstById(string id)
    {
        return _list.First(instance => instance.Uuid == id);
    }

    public Collection<T> GetAllById(string id)
    {
        return new Collection<T>(_list.Where(instance => instance.Uuid == id).ToList());
    }
    
    public void Delete(T instanceToDelete)
    {
        _list.Remove(instanceToDelete);
        Reserialize();
    }

    public void Reserialize()
    {
        File.WriteAllText(_path, JsonConvert.SerializeObject(_list));
    }

    public AccountDataSerializer (string path)
    {
        this._path = path;
        this._list = GetList();
    }
}
