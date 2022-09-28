using CommunityToolkit.Mvvm.ComponentModel;
using Org.Apache.Http.Authentication;
using System;
using System.Runtime.CompilerServices;

namespace ProfileClasses
{
    public class Account : ObservableObject
    {
        // public AccountStatus { get; private set; } TODO: Sukurti ProfileStatus enum (Pvz. enum ProfileStatus { Client, Distributor })
        private string userName;
        private string password;
        public string UserName { get => userName; set => SetProperty(ref userName, value); } // For ProfileStatus == Client it is a user created name and for Distributors - the name of their establishment

        public string Password { get => password; set => SetProperty(ref password, value); }

        public Account() { }
    }

    public class Profile : Account 
    {

        // public Kitchen[] Kitchens // For ProfileStatus == Client it is preferred kitchens to eat and for Distributors it is the Kitchens that they serve
        private string email;
        private string phoneNumber;
        public string Email { get => email; set => SetProperty(ref email, value); }

        public string PhoneNumber { get => phoneNumber; set => SetProperty(ref phoneNumber, value); }

        // public Address Location TODO: Sukurti Address class / struct.

        public Profile() { }
    }

}