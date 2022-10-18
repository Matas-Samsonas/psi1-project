using CommunityToolkit.Mvvm.Input;
using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

}

