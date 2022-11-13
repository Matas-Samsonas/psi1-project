using System.Collections.ObjectModel;
using Newtonsoft.Json;
// ReSharper disable StringCompareIsCultureSpecific.1
namespace AccountDataSerializer;
using ClassLibrary;
using ProfileClasses;
using PSI_MobileApp;
public class AccountDataSerializer<T> where T : class, IUsingUUID
{
    private string _path;
    private ObservableCollection<T> _list;
    private JsonSerializer _serializer;
    public ObservableCollection<T> List { get { return _list; } set { _list = value; } }
    public void Add(T newInstance)
    {
        _list.Add(newInstance);
        Reserialize();
    }

    public ObservableCollection<T> GetList()
    {
        if (!File.Exists(_path))
        {
            using (File.Create(_path)) { }
        }
        if (JsonConvert.DeserializeObject<ObservableCollection<T>>(File.ReadAllText(_path)) == null)
        {
            return new ObservableCollection<T>();
        }
        return JsonConvert.DeserializeObject<ObservableCollection<T>>(File.ReadAllText(_path));
    }

    public T GetFirstById(Guid id)
    {
        return _list.First(instance => instance.Id == id);
    }

    public ObservableCollection<T> GetAllById(Guid id)
    {
        return new ObservableCollection<T>(_list.Where(instance => instance.Id == id).ToList());
    }

    public void Delete(T instanceToDelete)
    {
        _list.Remove(instanceToDelete);
        Reserialize();
    }

    public void Reserialize()
    {
        using (var file = File.CreateText(_path))
        {
            _serializer.Serialize(file, _list);
        }
    }

    public AccountDataSerializer(string path)
    {
        this._path = path;
        this._list = GetList();
        this._serializer = new JsonSerializer();
        _serializer.Formatting = Formatting.Indented;
    }
}