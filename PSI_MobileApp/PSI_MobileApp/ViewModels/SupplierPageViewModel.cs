using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ProfileClasses;

namespace PSI_MobileApp.ViewModels
{
    public class SupplierPageViewModel : ObservableObject
    {
        public ObservableCollection<Profile> Profiles
        {
            get; private set;
        }

        public SupplierPageViewModel()
        {
            Profiles = new ObservableCollection<Profile>()
            {
                new Profile{Email = "test1", PhoneNumber = "test12"},
                new Profile{Email = "test2", PhoneNumber = "test13"},
                new Profile{Email = "test3", PhoneNumber = "test14"},
                new Profile{Email = "test4", PhoneNumber = "test15"},
                new Profile{Email = "test5", PhoneNumber = "test16"},
                new Profile{Email = "test6", PhoneNumber = "test17"}
            };
        }

        
        
    }

}
