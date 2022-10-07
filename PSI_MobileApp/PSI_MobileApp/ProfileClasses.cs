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

    public partial class Profile
    {
        private string _email;
        private string _password;
        private Account _account;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        
    }

}