using PSI_MobileApp.ViewModels;
using System.Text.RegularExpressions;

namespace PSI_MobileApp;

public partial class NewOrderPage : ContentPage
{
	public NewOrderPage(NewOrderViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}