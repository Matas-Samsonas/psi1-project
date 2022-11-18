using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProfileClasses;

namespace PSI_MobileApp.ViewModels
{
    public partial class DetailPageViewModel : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        string name;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string email;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            
            if ((query["Name"] != null) && (query["Password"] != null) && (query["Email"] != null))
            {
                Name = query["Name"] as string;
                Password = query["Password"] as string;
                Email = query["Email"] as string;
            }
            else
                throw new NotImplementedException();
        }
    }
}
