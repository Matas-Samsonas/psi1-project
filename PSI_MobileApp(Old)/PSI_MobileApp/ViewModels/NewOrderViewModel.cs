using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.RegularExpressions;

namespace PSI_MobileApp.ViewModels
{
    public partial class NewOrderViewModel : ObservableObject
    {
        [ObservableProperty]
        string dishName;

        [ObservableProperty]
        TimeSpan timeLimit = TimeSpan.Zero;

        [ObservableProperty]
        string incorrect = "";

        [RelayCommand]
        public async void Confirm()
        {
            if (!String.IsNullOrEmpty(dishName))
            {
              
                var advertisement = new Advertisement();
                advertisement.MealName = dishName;
                advertisement.PickupTimeSpan = timeLimit;
                advertisement.TimeOfMaking = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                advertisement.IsReserved = false;
                var navigationParameter = new Dictionary<string, object>
                {
                    { "advertisement", advertisement }
                };
                await Shell.Current.GoToAsync("..", navigationParameter);
                
            }
        }

        [RelayCommand]
        public async void Cancel()
        {
            var check = await Shell.Current.DisplayAlert("Are you sure?", "Are you sure you want to cancel the order creation?", "Yes", "No");
            if (check)
                await Shell.Current.GoToAsync("..");
            else
                return;
        }


    }
}
