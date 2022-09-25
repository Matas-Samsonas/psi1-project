using CommunityToolkit.Mvvm.ComponentModel;

namespace ProfileClasses
{
    public class Profile : ObservableObject
    {
        private string username;
        private string password;
        private string email;
        public string UserName { 
            get => username; 
            set => SetProperty(ref username, value); 
        }

        public string Password { 
            get => password;
            set => SetProperty(ref password, value); 
        }

        public string Email { 
            get => email; 
            set => SetProperty(ref email, value); 
        }

        public string PhoneNumber { get; set; }

        // public Address Location TODO: Sukurti Address class / struct.

        public Profile() { }
    }

    public class Client : Profile
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        // public Kitchen [] PreferredKitchen Virtuvių tipus darysime kaip enum ar ne (PVZ. enum Kitchen {Traditional, Chinese, Thai...})?

        public Distributor [] Subscriptions;

        public Client() { }  
    }

    public class Distributor : Profile
    {
        public string EstablishmentName { get; set; }

        public double Ratings { get; set; }

        public int amountOfReviews;

        // public Kitchen [] OfferedKitchens;

        public Distributor() { }
    }
    
}