using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Layouts;
using ProfileClasses;


namespace PSI_MobileApp.ViewModels
{
    public partial class SupplierDetailViewModel : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        private Profile supplierProfile;

        [ObservableProperty]
        private Image supplierImage;

        [ObservableProperty]
        private Advertisement selectedAdvert;

        [ObservableProperty]
        private string address;

       

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("profile") && (SupplierProfile == null))
            {
                SupplierProfile = query["profile"] as Profile;
                OnPropertyChanged("profile");
                if (SupplierProfile.Advertisements == null)
                    SupplierProfile.Advertisements = new();
                Address = SupplierProfile.Address.city + ", " + SupplierProfile.Address.streetName + " " + SupplierProfile.Address.streetNumber;
               
            }
            if (query.ContainsKey("advertisement"))
            {
                var tmp = query["advertisement"] as Advertisement;
                OnPropertyChanged("profile");
                supplierProfile.Advertisements.Add(tmp);
            }
         
            query.Clear();

        }

        [RelayCommand]
        public async void ConfirmOrder()
        {
            bool answ;
            if (selectedAdvert != null)
            {
                if (!selectedAdvert.IsReserved)
                {
                    answ = await Shell.Current.DisplayAlert("Are you sure?", "Do you want to reserve the chosen order?", "Yes", "No");
                }
                else
                {
                    answ = await Shell.Current.DisplayAlert("Are you sure?", "Do you want to remove your reservation of the chosen order?", "Yes", "No");
                }
                if (answ)
                    selectedAdvert.IsReserved = !selectedAdvert.IsReserved;
            }
        }

        [RelayCommand]
        public async void AddOrder()
        {
            await Shell.Current.GoToAsync(nameof(NewOrderPage));
        }

        [RelayCommand]
        public async void RemoveOrder()
        {
            if (selectedAdvert != null)
            {
                bool answ = await Shell.Current.DisplayAlert("Are you sure?", "Do you want to remove the chosen order?", "Yes", "No");
                if (answ)
                    supplierProfile.Advertisements.Remove(selectedAdvert);
                else
                    return;
            }
        }

        
    }
}
