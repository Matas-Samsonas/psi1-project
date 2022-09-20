using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PSI_MobileApp.ViewModels
{
    public partial class SupplierPageViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoHome()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
