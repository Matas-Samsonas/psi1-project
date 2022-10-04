using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProfileClasses;

namespace PSI_MobileApp.ViewModels
{

    public partial class NewUserViewModel : ObservableObject
    {
       
        [ObservableProperty]
        Profile profile = new();

        [ObservableProperty]
        string conPassword;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrEmpty(profile.UserName) || 
                string.IsNullOrEmpty(profile.Password) || 
                string.IsNullOrEmpty(profile.Email) || 
                string.IsNullOrEmpty(conPassword))
                return;

            if (!string.Equals(profile.Password, conPassword))
            {
                await Shell.Current.DisplayAlert("Passwords do not match.", "Please check the password and try again.", "OK");
                return;
            }
            //await Shell.Current.DisplayAlert(profile.UserName, profile.Password, profile.Email);
            await Shell.Current.GoToAsync($"..?Name={profile.UserName}&Password={profile.Password}&Email={profile.Email}");
            
        }
    }
}
