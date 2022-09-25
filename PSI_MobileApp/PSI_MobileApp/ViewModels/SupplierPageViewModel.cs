using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ProfileClasses;

namespace PSI_MobileApp.ViewModels
{
    public partial class SupplierPageViewModel : ObservableObject, IQueryAttributable
    {

        // collectioon of users/profiles
        [ObservableProperty]
        ObservableCollection<Profile> users = new();


        [RelayCommand]
        async Task GoHome()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task AddUser()
        {
            await Shell.Current.GoToAsync($"{nameof(NewUserPage)}");
        }

        [RelayCommand]
        async Task Tap(Profile p)
        {
            //await Shell.Current.DisplayAlert(users[0].UserName, users[0].Password, users[0].Email);
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Name={p.UserName}&Password={p.Password}&Email={p.Email}");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.Count() > 0)
            {
                if ((query["Name"] != null) && (query["Password"] != null) && (query["Email"] != null))
                {
                    Profile tmp = new()
                    {
                        UserName = query["Name"] as string,
                        Password = query["Password"] as string,
                        Email = query["Email"] as string
                    };

                    Users.Add(tmp);
                    query.Clear();
                }
                else
                    throw new NotImplementedException();
            }
        }
    }

}
