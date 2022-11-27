using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProfileClasses;
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
        string username;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string email;

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
            if (!string.IsNullOrEmpty(username) &&
                !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(conPassword))
            {
                if (Username.Any(Char.IsWhiteSpace))
                {
                    InvalidLabelText += "Username";
                    incorrect = true;
                    incorrectNum++;
                }
                if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    // maybe do something
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText += "Email";
                    incorrect = true;
                    incorrectNum++;
                }
                if (Password.Any(Char.IsWhiteSpace) || password.Length < 8)
                {
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText += "Password";
                    incorrect = true;
                    incorrectNum++;
                }
                if (ConPassword.Any(Char.IsWhiteSpace) || conPassword.Length < 8)
                {
                    if (incorrectNum > 0)
                        InvalidLabelText += ", ";
                    InvalidLabelText += "Confirm password";
                    incorrect = true;
                    incorrectNum++;
                }

                if (incorrect != true)
                {
                    if (!string.Equals(password, conPassword))
                    {
                        await Shell.Current.DisplayAlert("Passwords do not match.", "Please check the password and try again.", "OK");
                        return;
                    }
                    if (connectivity.NetworkAccess != NetworkAccess.Internet)
                    {
                        // possibly we should move the connectivity checking into somwhere before the functionalities of the program.
                        // this should only be temporrary.
                        await Shell.Current.DisplayAlert("No internet connection.", "Please check your internet connection and try again.", "OK");
                        return;
                    }

                    //await Shell.Current.DisplayAlert(profile.UserName, profile.Password, profile.Email);
                    //add to file
                    await Shell.Current.GoToAsync($"..?Name={Username}&Password={Password}&Email={Email}");
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