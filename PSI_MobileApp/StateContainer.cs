using ProfileClasses;

namespace PSI_MobileApp
{
    public class StateContainer
    {
        private Profile profile;
        private bool creatingDistributor = false;
        private Profile tempProfile;
        private Account tempAccount;
        private Account currentAccount = null;
        public Account CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; }
        }
        public bool CreatingDistributor
        {
            get { return creatingDistributor; }
            set { creatingDistributor = value; }
        }
        public Account TempAccount
        {
            get => tempAccount;
            set
            {
                tempAccount = value;
            }
        }
        public Profile TempProfile
        {
            get => tempProfile;
            set
            {
                tempProfile = value;
            }
        }
        public Profile Supplier
        {
            get => profile;
            set
            {
                profile = value;
                NotifyStateChanged();
            }
        }

#nullable enable
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
