using CommunityToolkit.Mvvm.ComponentModel;
using PSI_MobileApp;
using System.Collections.ObjectModel;

namespace ProfileClasses
{
    public struct Account
    {
        public string userName;
        public string password;
        public string uuid;
    }

    public partial class Profile : ObservableObject, IUsingUUID
    {
        [ObservableProperty]
        public Account account;
        [ObservableProperty]
        private string email;
        [ObservableProperty]
        private string phoneNumber;
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private double rating;
        [ObservableProperty]
        private Address address;
        [ObservableProperty]
        ObservableCollection<Advertisement> advertisements;
        [ObservableProperty]
        private string[] cuisines;

        public string Uuid { get; set; }
    }

}