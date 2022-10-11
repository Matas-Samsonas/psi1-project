using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using ProfileClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp.ViewModels
{
    public partial class SupplierDetailViewModel : ObservableObject, IQueryAttributable, INotifyPropertyChanged
    {
        [ObservableProperty]
        private Profile supplierProfile;

        [ObservableProperty]
        private Image supplierImage;

        
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SupplierProfile = query["profile"] as Profile;
            OnPropertyChanged("profile");
        }
    }
}
