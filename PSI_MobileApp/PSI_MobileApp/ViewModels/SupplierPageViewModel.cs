using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ProfileClasses;
using AccountDataSerializer;
using System.Windows.Input;
using System.Diagnostics;
using Microsoft.Maui.Controls;
using System.Linq;

namespace PSI_MobileApp.ViewModels
{
    public partial class SupplierPageViewModel : ObservableObject
    {
        private AccountDataSerializer<Profile> _dataSerializer;
        private ObservableCollection<Profile> _searchResult;
        private List<string> _cuisineTags = Enum.GetNames(typeof(Cuisines)).ToList();
        private string _lastSearch = "";

        public List<string> CuisineTags
        {
            get { return _cuisineTags; }
            set { _cuisineTags = value; }
        }
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

        public ICommand searchCommand => new Command<string>((query) =>
        {
            _lastSearch = query;
            SearchResults = DataSearch.getSearchResults<Profile>(Profiles,searchQuery: query);
        });

        public ICommand OnTagClicked => new Command<string>((tag) =>
        {
                SearchResults = DataSearch.getSearchResults<Profile>(Profiles, searchQuery: _lastSearch,
                    con: (Profile profile) => profile.Cuisines.Contains(tag)
                    );
        });

        public ICommand RemoveTag => new Command<CollectionView>((tag) =>
        {
            tag.SelectedItem = null;
            SearchResults = DataSearch.getSearchResults<Profile>(Profiles, searchQuery: _lastSearch
                    );
        });
        

        public SupplierPageViewModel()
        {
            _dataSerializer = new AccountDataSerializer<Profile>("C:\\Users\\jorun\\source\\repos\\psi1-project\\psi\\PSI_MobileApp\\PSI_MobileApp\\Resources\\DataFiles\\ProfileData.json");
            Profiles = _dataSerializer.List;
            SearchResults = Profiles;
            //_dataSerializer.Add(new Profile { Name = "test5", Email = "email5", PhoneNumber = "number5", Rating = 5 });
        }

        
        
    }

}
