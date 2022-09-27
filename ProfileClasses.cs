using System;

namespace ProfileClasses
{
    public class Profile
    {
        //public ProfileStatus { get; private set; } TODO: Sukurti ProfileStatus enum (Pvz. enum ProfileStatus { Client, Distributor })
        
        public Kitchen[] Kitchens // For ProfileStatus == Client it is preferred kitchens to eat and for Distributors it is the Kitchens that they serve
        
        public string UserName { get; set; } // For ProfileStatus == Client it is a user created name and for Distributors - the name of their establishment

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        // public Address Location TODO: Sukurti Address class / struct.

        public Profile() { }
    }
    
}
