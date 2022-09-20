using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PSI_MobileApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    { 

        [RelayCommand]
        async Task GoSupplierListPage()
        {
            await Shell.Current.GoToAsync(nameof(SupplierListPage));
        }

    }
}
