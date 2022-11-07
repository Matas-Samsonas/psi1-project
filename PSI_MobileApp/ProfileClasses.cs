
using PSI_MobileApp;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ProfileClasses
{
    public struct Account
    {
        private string _userName;
        private string _password;
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Profile : IUsingUUID
    {
        private Guid _uuid;
        private string _email;
        private string _phoneNumber;
        
        private string _name;
        private double _rating;
        private Address _address;
        private string[] _cuisines;
        private ObservableCollection<Advertisement> _advertisements;
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Rating { get { return _rating; } set { _rating = value; } }
        public string[] Cuisines { get { return _cuisines; } set { _cuisines = value; } }
        public Guid Uuid { get { return _uuid; } set { _uuid = value; } }
        public Address Address { get { return _address; } set { _address = value; } }
        public ObservableCollection<Advertisement> Advertisements { get { return _advertisements; } set { _advertisements = value; } }
        
    }

}