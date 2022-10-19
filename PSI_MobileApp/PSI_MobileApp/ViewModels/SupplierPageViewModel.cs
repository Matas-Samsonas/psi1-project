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
        static bool isRuning;

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
            TimeSpanHandler();
            //_dataSerializer.Add(new Profile { Name = "test5", Email = "email5", PhoneNumber = "number5", Rating = 5 });
        }

        async void TimeSpanHandler()
        {

            await Task.Run(async () =>
            {
                if (!isRuning)
                {
                    var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
                    isRuning = true;
                    while (await timer.WaitForNextTickAsync())
                    {
                        foreach (var j in Profiles)
                        {
                            if (j.Advertisements == null)
                                j.Advertisements = new();

                            foreach (var i in j.Advertisements.ToList())
                            {
                                if (i.PickupTimeSpan.Equals(TimeSpan.Zero))
                                {
                                    j.Advertisements.Remove(i);
                                }
                                else
                                {
                                    i.PickupTimeSpan = i.PickupTimeSpan.Subtract(TimeSpan.FromSeconds(1));
                                }


                            }

                        }
                    }
                }
            });
        }


    }

}
