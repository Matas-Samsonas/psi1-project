using CommunityToolkit.Mvvm.ComponentModel;
using PSI_MobileApp;
using System.Collections;

namespace ProfileClasses
{
    public struct Account
    {
        private string _userName;
        private string _password;
        public string UserName { get; private set; }
        public string Password { get; private set; }
    }

    public class Profile : IUsingUUID
    {
        private string _uuid;
        private string _email;
        private string _phoneNumber;
        private string _name;
        private double _rating;
        private string[] _cuisines;
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Rating { get { return _rating; } set { _rating = value; } }
        public string[] Cuisines { get { return _cuisines; } set { _cuisines = value; } }
        public string Uuid { get { return _uuid; } set { _uuid = value; } }
    }

}