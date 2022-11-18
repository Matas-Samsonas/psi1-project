using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class NewUserPage : ContentPage
{
	public NewUserPage(NewUserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}