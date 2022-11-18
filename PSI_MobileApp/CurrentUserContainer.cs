﻿using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using ProfileClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class CurrentUserContainer
    {
        private Guid? _userId { get; set; }
        private Lazy<Account> _userAccount { get; set; }
        private Lazy<Profile> _userProfile { get; set; }
        private Lazy<Distributor> _userDistributor { get; set; }
        public Guid? UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public Account GetUserAccount()
        {
            return _userAccount.Value;
        }
        public Profile GetUserProfile()
        {
            return _userProfile.Value;
        }
        public Distributor GetUserDistributor()
        {
            return _userDistributor.Value;
        }
        public Account GetAccountFromDB()
        {
            using (ProjectDatabaseContext context = new())
            {
                return context.Accounts.Where(profile => profile.Id == this.UserId).FirstOrDefault();
            }
        }

        public Profile GetProfileFromDB()
        {
            using (ProjectDatabaseContext context = new())
            {
                return context.Profiles.Where(profile => profile.Id == this.UserId).FirstOrDefault();
            }
        }
        public Distributor GetDistributorFromDB()
        {
            using (ProjectDatabaseContext context = new())
            {
                return context.Distributors.Where(profile => profile.Id == this.UserId).FirstOrDefault();
            }
        }

        public void Logout()
        {
            UserId = null;
            _userDistributor = new Lazy<Distributor>(delegate () { return GetDistributorFromDB(); }); ;
            _userAccount = new Lazy<Account>(delegate () { return GetAccountFromDB(); });
            _userProfile = new Lazy<Profile>(delegate () { return GetProfileFromDB(); });
        }
        public CurrentUserContainer()
        {
            this._userAccount = new Lazy<Account>(delegate () { return GetAccountFromDB(); });
            this._userProfile = new Lazy<Profile>(delegate () { return GetProfileFromDB(); });
            this._userDistributor = new Lazy<Distributor>(delegate () { return GetDistributorFromDB(); });

        }
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }


}

