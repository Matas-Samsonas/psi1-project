
namespace PSI_MobileApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SupplierListPage), typeof(SupplierListPage));
        //Routing.RegisterRoute(nameof(NewUserPage), typeof(NewUserPage));
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));

        Routing.RegisterRoute(nameof(SupplierDetailPage), typeof(SupplierDetailPage));
        Routing.RegisterRoute(nameof(NewOrderPage), typeof(NewOrderPage));
    }
}
