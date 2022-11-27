using CommunityToolkit.Mvvm.Input;
using ProfileClasses;
using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class SupplierListPage : ContentPage
{
    public SupplierListPage(SupplierPageViewModel vm)
    {

        InitializeComponent();
        BindingContext = vm;
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Profile p = e.Item as Profile;
        var navigationParameter = new Dictionary<string, object>
        {
            { "profile", p }
        };
        await Shell.Current.GoToAsync($"{nameof(SupplierDetailPage)}", navigationParameter);
    }
}