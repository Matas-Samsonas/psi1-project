using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ProfileClasses;
using AccountDataSerializer;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace PSI_MobileApp.ViewModels
{
    public class SupplierPageViewModel : ObservableObject
    { 
        private AccountDataSerializer<Profile> _dataSerializer;

        public ICommand searchCommand => new Command<string>((query) =>
        {
            SearchResults = DataSearch.getSearchResults<Profile>(Profiles,searchQuery: query);
        });

        private ObservableCollection<Profile> _searchResult;
        public ObservableCollection<Profile> SearchResults
        {
            get
            { return _searchResult; }
            set 
            {
                _searchResult = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<Profile> Profiles
        {
            get; private set;
        }

        public SupplierPageViewModel()
        {
            _dataSerializer = new AccountDataSerializer<Profile>("C:\\Users\\jorun\\source\\repos\\psi1-project\\psi\\PSI_MobileApp\\PSI_MobileApp\\Resources\\DataFiles\\ProfileData.json");
            Profiles = _dataSerializer.List;
            SearchResults = Profiles;
            //_dataSerializer.Add(new Profile { Name = "test5", Email = "email5", PhoneNumber = "number5", Rating = 5 });
        }

        
        
    }

}
