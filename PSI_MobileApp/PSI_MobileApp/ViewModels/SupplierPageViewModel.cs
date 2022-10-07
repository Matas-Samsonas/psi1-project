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
                new Profile{Email = "test1", PhoneNumber = "test12", Name = "Name1", Rating = 4},
                new Profile{Email = "test2", PhoneNumber = "test12", Name = "Name1", Rating = 4},
                new Profile{Email = "test3", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test4", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test5", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test6", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test7", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test8", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test9", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                new Profile{Email = "test10", PhoneNumber = "test12", Name = "Name1", Rating = 4.0},
                
            };
        }

        
        
    }

}
