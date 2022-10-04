using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Networking;
using ProfileClasses;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace PSI_MobileApp.ViewModels
{

    public partial class NewUserViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public NewUserViewModel(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
            
        }
        

        [ObservableProperty]
        Profile profile = new();

        [ObservableProperty]
        string conPassword;

        [ObservableProperty]
        public bool invalidLabelVisibility = false;

        [ObservableProperty]
        public string invalidLabelText;

        [RelayCommand]
        async Task Add()
        {
            bool incorrect = false;
            int incorrectNum = 0;
            InvalidLabelText = "";
            if (!string.IsNullOrEmpty(profile.UserName) &&
                !string.IsNullOrEmpty(profile.Password) &&
                !string.IsNullOrEmpty(profile.Email) &&
                !string.IsNullOrEmpty(conPassword))
            {
                if (profile.UserName.Any(Char.IsWhiteSpace))
                {
                    InvalidLabelText += "Username";
                    incorrect = true;
                    incorrectNum++;
                }
                if (!Regex.IsMatch(profile.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    // maybe do something
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText +="Email";
                    incorrect = true;
                    incorrectNum++;
                }
                if (profile.Password.Any(Char.IsWhiteSpace) || profile.Password.Length < 8)
                {
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText += "Password";
                    incorrect = true;
                    incorrectNum++;
                }
                if (ConPassword.Any(Char.IsWhiteSpace) || profile.Password.Length < 8)
                {
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText += "Confirm password";
                    incorrect = true;
                    incorrectNum++;
                }

                if (incorrect != true)
                {
                    if (!string.Equals(profile.Password, conPassword))
                    {
                        await Shell.Current.DisplayAlert("Passwords do not match.", "Please check the password and try again.", "OK");
                        return;
                    }
                    if (connectivity.NetworkAccess != NetworkAccess.Internet)
                    {
                        // possibly we should move the connectivity checking into somwhere before the functionalities of the program.
                        // this should only be temporrary.
                        await Shell.Current.DisplayAlert("No internet connection.", "Plesase check your internet connection and try again.", "OK");
                        return;
                    }

                    //await Shell.Current.DisplayAlert(profile.UserName, profile.Password, profile.Email);
                    await Shell.Current.GoToAsync($"..?Name={profile.UserName}&Password={profile.Password}&Email={profile.Email}");
                }
                else
                {
                    InvalidLabelText += " must not have whitespaces and be correct.";
                    InvalidLabelVisibility = true;
                    return;
                }
            }
            else
            {
                InvalidLabelText += "Fields must be not empty.";
                InvalidLabelVisibility = true;
                return;
            }
        }


    }

}
