﻿using ProfileClasses;
using PSI_MobileApp.Extensions;
using System.Collections.ObjectModel;

namespace PSI_MobileApp
{
    public static class DataSearch
    {

        public static ObservableCollection<T> getSearchResults<T>(ObservableCollection<T> items,
            string searchQuery = "", Func<T, bool> con = null) where T : Profile
        {
            var searchResult = new ObservableCollection<T>();
            if(con != null)
            {
                searchResult =
                (from item in items
                 where item.Name.Contains(searchQuery) && con(item)
                 select item).ToObservableCollection();
            }else
            {
                searchResult =
                (from item in items
                 where item.Name.Contains(searchQuery)
                 select item).ToObservableCollection();
            }
            
            
            return searchResult;
        }

        

    }
}
