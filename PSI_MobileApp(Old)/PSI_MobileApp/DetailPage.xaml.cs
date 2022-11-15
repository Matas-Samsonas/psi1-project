using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}