namespace PSI_MobileApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SupplierListPage), typeof(SupplierListPage));
	}
}
