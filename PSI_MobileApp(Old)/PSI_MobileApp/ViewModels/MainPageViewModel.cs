using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace PSI_MobileApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string viewPoint = "Supplier";

        internal static bool isSupplier = true;

        [RelayCommand]
        public void SwitchPrespectives()
        {
            if (isSupplier)
            {
                ViewPoint = "User";
            }
            else
            {
                ViewPoint = "Supplier";
            }
            isSupplier = !isSupplier;


        }



        [RelayCommand]
        async Task AddUser()
        {
            await Shell.Current.GoToAsync($"{nameof(NewUserPage)}");
        }
    }
}
