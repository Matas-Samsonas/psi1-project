using CommunityToolkit.Mvvm.ComponentModel;
using PSI_MobileApp;
using System.Collections;
using System.Collections.ObjectModel;

namespace ProfileClasses
{
    public struct Account
    {
        private string userName;
        private string password;
        private string uuid;
    }

    public partial class Profile : ObservableObject
    {
        [ObservableProperty]
        private Account account;
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
        
    }

}