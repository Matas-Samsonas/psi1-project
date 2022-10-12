

using ProfileClasses;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PSI_MobileApp
{
    public static class DataSearch
    {

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> items)
        {
            return new ObservableCollection<T>(items);
        }

        public static ObservableCollection<T> getSearchResults<T>(ObservableCollection<T> items,
            Func<T, bool> condition = null, string searchQuery = "") where T : Profile
        {

            ObservableCollection<T> searchResult =
                (from item in items
                 where item.Name.Contains(searchQuery)
                 select item).ToObservableCollection();
            
            return searchResult;
        }

    }
}
