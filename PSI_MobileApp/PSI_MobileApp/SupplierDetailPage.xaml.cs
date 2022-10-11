using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public partial class SupplierDetailPage : ContentPage
{
	public SupplierDetailPage(SupplierDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}