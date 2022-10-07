using CommunityToolkit.Mvvm.Input;

namespace PSI_MobileApp;

public partial class SupplierDemoView : ContentView
{

	public static readonly BindableProperty SupplierNameProperty =
		BindableProperty.Create(nameof(SupplierName), typeof(string), typeof(SupplierDemoView), string.Empty);

    public static readonly BindableProperty SupplierImageSourceProperty =
        BindableProperty.Create(nameof(SupplierImageSource), typeof(ImageSource), typeof(SupplierDemoView), null);
   
	public static readonly BindableProperty SupplierRatingProperty =
		BindableProperty.Create(nameof(SupplierRating), typeof(double), typeof(SupplierDemoView), 0.0);

    public static readonly BindableProperty SupplierEmailProperty =
        BindableProperty.Create(nameof(SupplierEmail), typeof(string), typeof(SupplierDemoView), string.Empty);

    public static readonly BindableProperty SupplierPhoneNumberProperty =
        BindableProperty.Create(nameof(SupplierPhoneNumber), typeof(string), typeof(SupplierDemoView), string.Empty);

    public string SupplierName
	{
		get => (string)GetValue(SupplierNameProperty);
		set => SetValue(SupplierNameProperty, value);
	}
	public ImageSource SupplierImageSource
	{
		get => (ImageSource)GetValue(SupplierImageSourceProperty);
		set => SetValue(SupplierImageSourceProperty, value);
	}
	public double SupplierRating
	{
		get => (double)GetValue(SupplierRatingProperty);
		set => SetValue(SupplierRatingProperty, value);
	}

	public string SupplierEmail
	{
		get => (string)GetValue(SupplierEmailProperty);
		set => SetValue(SupplierEmailProperty, value);
	}

	public string SupplierPhoneNumber
	{
		get => (string)GetValue(SupplierPhoneNumberProperty);
		set => SetValue(SupplierPhoneNumberProperty, value);
	}
	

	public SupplierDemoView()
	{
		InitializeComponent();
	}
}