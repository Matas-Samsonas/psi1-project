using PSI_MobileApp.ViewModels;

namespace PSI_MobileApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();

		builder.Services.AddSingleton<SupplierListPage>();
		builder.Services.AddSingleton<SupplierPageViewModel>();

		builder.Services.AddTransient<NewUserPage>();
		builder.Services.AddTransient<NewUserViewModel>();

        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<DetailPageViewModel>();

        builder.Services.AddTransient<SupplierDetailPage>();
        builder.Services.AddTransient<SupplierDetailViewModel>();

        return builder.Build();
	}
}
