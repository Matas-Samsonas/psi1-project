using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class SupplierListPage : ContentPage
{
	public SupplierListPage(SupplierPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}