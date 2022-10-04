using CommunityToolkit.Mvvm.ComponentModel;
using Org.Apache.Http.Authentication;
using System;
using System.Runtime.CompilerServices;

namespace ProfileClasses
{
    public partial class Account : ObservableObject
    {
        // public AccountStatus { get; private set; } TODO: Sukurti ProfileStatus enum (Pvz. enum ProfileStatus { Client, Distributor })
        [ObservableProperty]
        private string userName;
        [ObservableProperty]
        private string password;
       // public string UserName { get => userName; set => SetProperty(ref userName, value); } // For ProfileStatus == Client it is a user created name and for Distributors - the name of their establishment
        //public string UserName;
       // public string Password;

        public Account() { }
    }

    public partial class Profile : Account 
    {

        // public Kitchen[] Kitchens // For ProfileStatus == Client it is preferred kitchens to eat and for Distributors it is the Kitchens that they serve
        [ObservableProperty]
        private string email;
        [ObservableProperty]
        private string phoneNumber;
       // public string Email;

        //public string PhoneNumber;

        // public Address Location TODO: Sukurti Address class / struct.

        public Profile() { }
    }

}