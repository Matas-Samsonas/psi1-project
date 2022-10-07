using CommunityToolkit.Mvvm.ComponentModel;
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

    public class Profile
    {
        private Account _account;

        private string _email;
        private string _phoneNumber;
        private string _name;
        private double _rating;
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Rating { get { return _rating; } set { _rating = value; } }
        public Account Account { get { return _account; } }
        
        
    }

}