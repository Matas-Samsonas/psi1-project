using System;

namespace ProfileClasses
{
    public class Profile
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

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