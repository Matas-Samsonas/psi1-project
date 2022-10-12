using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProfileClasses;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
            SupplierProfile = query["profile"] as Profile;
            OnPropertyChanged("profile");
            Address = SupplierProfile.Address.city + ", " + SupplierProfile.Address.streetName + " " + SupplierProfile.Address.streetNumber;
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
            Advertisement advertisement = new();
            do
            {
                advertisement.MealName = await Shell.Current.DisplayPromptAsync("Name", "What is the dish called?");
                if (advertisement.MealName == null)
                    return;
            }
            while (advertisement.MealName == "");
            
            do
            { 
                advertisement.PickupTimeSpan = await Shell.Current.DisplayPromptAsync("Pickup time limit", "What is the dishes pickup time limit? (From 0-9)", keyboard: Keyboard.Numeric, maxLength: 1) + "h";
                if (advertisement.PickupTimeSpan == null)
                    return;                    
            }
            while (advertisement.PickupTimeSpan == "h");

            advertisement.TimeOfMaking = DateTime.Now.ToString("HH:mm");
            if (supplierProfile.Advertisements != null)
            {
                supplierProfile.Advertisements.Add(advertisement);
            }
            else
            {
                supplierProfile.Advertisements = new ObservableCollection<Advertisement>();
                supplierProfile.Advertisements.Add(advertisement);
            }
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
